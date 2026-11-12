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
        }

        public void ganhasteMula(object? sender, string texto)
        {
            mulaLabel.Text = texto;
        }

        private void corrigirOffset(object sender, EventArgs e)
        {
            mulaLabel.Left = mulaBordaDireita - mulaLabel.Width;
        }
    }
}
