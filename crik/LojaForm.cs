using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace crik
{
    public partial class LojaForm : Form
    {
        private int mulaBordaDireita;

        public LojaForm()
        {
            InitializeComponent();
            Globais.mudouMula += ganhasteMula;
            Disposed += (_, _) =>
            {
                Globais.mudouMula -= ganhasteMula;
            };
        }
        private void LojaForm_Load(object sender, EventArgs e)
        {
            mulaBordaDireita = mulaLabel.Right;
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";

            homenzinhoColabPicture.MouseClick += detectorDeClick;
            colabDescrQntdLabel.MouseClick += detectorDeClick;
            colabQntdLabel.MouseClick += detectorDeClick;
            updateColabUI();
        }

        public void ganhasteMula(int quantidade)
        {
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";
        }

        private void corrigirOffset(object sender, EventArgs e)
        {
            mulaLabel.Left = Globais.corrigirOffset(mulaLabel, mulaBordaDireita);
        }

        // Colaboradores

        private int colaboradoresNum = 1;
        private int colaboradoresTotalCusto = Globais.ColaboradoresCusto;

        private int custoCompraColaboradores()
        {
            // Preço inicial: Preço base * taxa de aumento elevado ao número de colaboradores já comprados
            // Preço atual: Preço inicial * ((taxa de aumento elevado ao número de colaboradores a comprar) - 1) / (taxa de aumento - 1)
            return (int)(Globais.ColaboradoresCusto * Math.Pow(1 + Globais.ColaboradoresTaxaAumento, Globais.Colaboradores) * ((Math.Pow(1 + Globais.ColaboradoresTaxaAumento, colaboradoresNum) - 1) / Globais.ColaboradoresTaxaAumento));
        }
        private void detectorDeClick(object? sender, MouseEventArgs e)
        {
            colaboradoresTotalCusto = custoCompraColaboradores();
            DialogResult resposta = MessageBox.Show(
                $"Deseja comprar {colaboradoresNum} colaboradores por {Globais.formatarQuantidade(colaboradoresTotalCusto)} bananas?",
                "Aviso de compra",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning 
            );
            if (resposta == DialogResult.OK)
            {
                if (Globais.comprarColaboradores(colaboradoresNum, colaboradoresTotalCusto))
                {
                    colaboradoresTotalCusto = custoCompraColaboradores();
                    updateColabUI();
                }
                else
                {
                    MessageBox.Show($"Você não tem bananas suficientes para comprar isso.\nFaltam {colaboradoresTotalCusto - Globais.Bananas} bananas.", "Erro de compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void colabBuy1Btn_Click(object sender, EventArgs e) // deve ter maneira melhor de fazer isso
        {
            colaboradoresNum = 1;
            colaboradoresTotalCusto = custoCompraColaboradores();
            updateColabUI();
        }

        private void colabBuy10Btn_Click(object sender, EventArgs e)
        {
            colaboradoresNum = 10;
            colaboradoresTotalCusto = custoCompraColaboradores();
            updateColabUI();
        }

        private void colabBuy100Btn_Click(object sender, EventArgs e)
        {
            colaboradoresNum = 100;
            colaboradoresTotalCusto = custoCompraColaboradores();
            updateColabUI();
        }

        private void updateColabUI()
        {
            colabQntdLabel.Text = colaboradoresNum.ToString();
            totalColabLabel.Text = $"total: {Globais.formatarQuantidade(colaboradoresTotalCusto)} bananas";
            producaoColabLabel.Text = $"Atualmente 1 colaborador gera {Globais.ColaboradoresProducao} bananas a cada {Globais.ColaboradoresTempo / 1000} segundos";
            descricaoColabLabel.Text = $"Selecione abaixo a quantidade de colaboradores que deseja contratar e em seguida clique no nosso caro ao lado para contratá-los!\r\nA cada contratação, o preço da próxima sobe em {(int)(Globais.ColaboradoresTaxaAumento * 100)}%";
        }
    }
}
