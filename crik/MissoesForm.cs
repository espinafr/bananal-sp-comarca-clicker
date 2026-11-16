namespace crik
{
    public partial class MissoesForm : Form
    {
        private int mulaBordaDireita;

        public MissoesForm()
        {
            InitializeComponent();
            AdicionarMissao();
        }

        private void MissoesForm_Load(object sender, EventArgs e)
        {
            mulaBordaDireita = mulaLabel.Right;
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";
        }

        public void ganhasteMula(int quantidade)
        {
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";
        }

        private void corrigirOffset(object sender, EventArgs e)
        {
            mulaLabel.Left = mulaBordaDireita - mulaLabel.Width;
        }

        public void AdicionarMissao(int meta = 200, int dificuldade = 0)
        {
            int recompensa = meta / 3;
            MissaoCard? missao = null;

            missao = new MissaoCard(
                $"guardando bananas{(dificuldade > 0 ? $" {dificuldade + 1}" : "")}",
                $"Junte {Globais.formatarQuantidade(meta)} bananas.",
                recompensa,
                dificuldade,
                () => Globais.Bananas >= meta,
                () =>
                {
                    if (missao is null)
                        return;

                    Globais.fireMissoes -= missao.Verificar;

                    Globais.ganharMula(recompensa);

                    missoesPanel.Controls.Remove(missao);
                    missao.Dispose();

                    double proximaMeta = Math.Ceiling(Math.Pow(meta, 1.5));

                    if (proximaMeta <= int.MaxValue)
                    {
                        AdicionarMissao(
                            (int)proximaMeta,
                            Math.Min(dificuldade + 1, 5));
                    }
                });

            Globais.fireMissoes += missao.Verificar;
            missoesPanel.Controls.Add(missao);
        }
    }
}

