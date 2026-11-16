using System.ComponentModel;

namespace crik
{
    public partial class MissaoCard : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Titulo { get; private set; } = string.Empty;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Descricao { get; private set; } = string.Empty;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Recompensa { get; private set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Dificuldade { get; private set; }

        private readonly Func<bool> Validador = () => false;

        private readonly Action Recompensador = () => { };

        private bool Completed = false;

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
                    dificuldadeLabel.ForeColor = Color.Orange;
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

        public MissaoCard(string titulo, string descricao, int recompensa, int dificuldade, Func<bool> validador, Action recompensador) : this()
        {
            Titulo = titulo;
            Descricao = descricao;
            Recompensa = recompensa;
            Dificuldade = dificuldade;
            Validador = validador;
            Recompensador = recompensador;

            tituloLabel.Text = Titulo;
            recompensaLabel.Text = $"{Globais.formatarQuantidade(Recompensa)} bananas";
            Globais.autoEscalar(tituloLabel, 14f, .6f);
            setarDificuldade(Dificuldade);
        }

        private void verButton_Click(object? sender, EventArgs e)
        {
            if (!Completed)
            {
                MessageBox.Show(FindForm(), $"{Descricao}\nRecompensa: {Globais.formatarQuantidade(Recompensa)} bananas", "Detalhes: " + Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(FindForm(), "Esta missão já foi concluída.", "Missão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Verificar()
        {
            if (!Completed && Validador())
            {
                Completed = true;
                verButton.Text = "Concluída";
                verButton.BackColor = Color.Green;

                Recompensador();
            }
        }
    }
}
