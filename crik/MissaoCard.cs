using System.ComponentModel;

namespace crik
{
    public partial class MissaoCard : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Missao? Missao { get; private set; }
        public MissaoCard()
        {
            InitializeComponent();
        }

        private void setarDificuldade(int dificuldade)
        {
            switch (dificuldade)
            {
                case 0:
                    dificuldadeLabel.ForeColor = Color.Cyan;
                    dificuldadeLabel.Text = "muito fácil";
                    break;
                case 1:
                    dificuldadeLabel.ForeColor = Color.Green;
                    dificuldadeLabel.Text = "fácil";
                    break;
                case 2:
                    dificuldadeLabel.ForeColor = Color.Chocolate;
                    dificuldadeLabel.Text = "razoável";
                    break;
                case 3:
                    dificuldadeLabel.ForeColor = Color.Red;
                    dificuldadeLabel.Text = "difícil";
                    break;
                case 4:
                    dificuldadeLabel.ForeColor = Color.Purple;
                    dificuldadeLabel.Text = "extremo";
                    break;
                default:
                    dificuldadeLabel.ForeColor = Color.Black;
                    dificuldadeLabel.Text = "impossível";
                    break;
            }
        }

        public MissaoCard(Missao missao) : this()
        {
            ArgumentNullException.ThrowIfNull(missao);
            Missao = missao;
            tituloLabel.Text = missao.Titulo;
            recompensaLabel.Text = $"{Globais.formatarQuantidade(missao.Recompensa)} bananas";
            Globais.autoEscalar(tituloLabel, 14f, .6f);
            setarDificuldade(missao.Dificuldade);
            missao.Concluida += AtualizarEstado;
            Disposed += (_, _) => missao.Concluida -= AtualizarEstado;
            AtualizarEstado();
        }

        private void AtualizarEstado()
        {
            if (Missao?.Completed == true)
            {
                verButton.Text = "Concluída";
                verButton.BackColor = Color.Green;
            }
        }

        private void verButton_Click(object? sender, EventArgs e)
        {
            if (Missao is null) return;
            MessageBox.Show(FindForm(), $"{(Missao.Completed ? "Esta missão já foi concluída.\n\n" : "")}{Missao.Descricao}\nRecompensa: {Globais.formatarQuantidade(Missao.Recompensa)} bananas",
                "Detalhes: " + Missao.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}