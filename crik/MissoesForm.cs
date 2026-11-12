using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace crik
{
    public partial class MissoesForm : Form
    {
        int mulaBordaDireita;

        public MissoesForm()
        {
            InitializeComponent();
        }

        private void MissoesForm_Load(object sender, EventArgs e)
        {
            mulaBordaDireita = mulaLabel.Right;
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";

            AdicionarMissao(
                titulo: "Colheita Rápida",
                descricaoInfo: "Colete 500 bananas clicando na árvore antes que o tempo acabe.",
                recompensa: "1,5 mil bananas",
                aoAceitar: () =>
                {
                    MessageBox.Show("Missão iniciada!");
                }
            );

            AdicionarMissao(
                titulo: "Fazendeiro Mestre",
                descricaoInfo: "Compre 5 melhorias na loja de fazenda.",
                recompensa: "10 mil bananas",
                aoAceitar: () =>
                {
                    // desenrola bate
                }
            );
        }

        public void ganhasteMula(object? sender, string texto)
        {
            mulaLabel.Text = texto;
        }

        private void corrigirOffset(object sender, EventArgs e)
        {
            mulaLabel.Left = mulaBordaDireita - mulaLabel.Width;
        }

        private void AdicionarMissao(string titulo, string descricaoInfo, string recompensa, Action aoAceitar)
        {
            Panel card = new Panel
            {
                Width = 200,
                Height = 110,
                BackColor = Color.DarkGreen,
                Margin = new Padding(8), // Espaçamento automático entre os cards no grid
                BorderStyle = BorderStyle.FixedSingle
            };

            // 2. Título da Missão
            Label lblTitulo = new Label
            {
                Text = titulo,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // 3. Label de Recompensa
            Label lblRecompensa = new Label
            {
                Text = "Recompensa: " + recompensa,
                ForeColor = Color.Yellow,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(10, 38),
                AutoSize = true
            };

            // 4. Botão "Info" (abre o popup)
            Button btnInfo = new Button
            {
                Text = "Info",
                Size = new Size(65, 28),
                Location = new Point(10, 70),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnInfo.Click += (s, e) =>
            {
                MessageBox.Show(descricaoInfo, "Detalhes: " + titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // 5. Botão "Aceitar"
            Button btnAceitar = new Button
            {
                Text = "Aceitar",
                Size = new Size(95, 28),
                Location = new Point(90, 70),
                BackColor = Color.Gold,
                FlatStyle = FlatStyle.Flat
            };
            btnAceitar.Click += (s, e) =>
            {
                aoAceitar?.Invoke(); // Executa a ação da missão
                missoesPanel.Controls.Remove(card); // Remove o card da grade após aceitar (opcional)
                card.Dispose();
            };

            // Adiciona os controles dentro do Card e o Card dentro do Grid
            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblRecompensa);
            card.Controls.Add(btnInfo);
            card.Controls.Add(btnAceitar);

            missoesPanel.Controls.Add(card);
        }

    }
}
