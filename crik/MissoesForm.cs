namespace crik
{
    public partial class MissoesForm : Form
    {
        private int mulaBordaDireita;

        public MissoesForm()
        {
            InitializeComponent();
            RenderizarMissoes();
            Globais.Missoes.ListChanged += MissoesAlteradas;
            Globais.mudouMula += ganhasteMula;
            Disposed += (_, _) =>
            {
                Globais.Missoes.ListChanged -= MissoesAlteradas;
                Globais.mudouMula -= ganhasteMula;
            };
        }

        private void MissoesForm_Load(object sender, EventArgs e)
        {
            mulaBordaDireita = mulaLabel.Right;
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";
        }

        public void mudasteMula(int quantidade)
        {
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";
        }

        private void corrigirOffset(object sender, EventArgs e)
        {
            mulaLabel.Left = Globais.corrigirOffset(mulaLabel, mulaBordaDireita);
        }

        private void MissoesAlteradas(object? sender, System.ComponentModel.ListChangedEventArgs e)
        {
            RenderizarMissoes();
        }

        private void RenderizarMissoes()
        {
            missoesPanel.SuspendLayout();
            try
            {
                while (missoesPanel.Controls.Count > 0)
                    missoesPanel.Controls[0].Dispose();

                foreach (var missao in Globais.Missoes)
                    missoesPanel.Controls.Add(new MissaoCard(missao));
            }
            finally
            {
                missoesPanel.ResumeLayout();
            }
        }
    }
}
