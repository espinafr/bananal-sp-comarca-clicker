using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crik
{
    public partial class mainForm : Form
    {
        private MissoesForm? missoesFormObj;
        private LojaForm? lojaFormObj;
        private readonly System.Windows.Forms.Timer colaboradoresTimer;

        public mainForm()
        {
            InitializeComponent();
            components ??= new System.ComponentModel.Container();
            colaboradoresTimer = new System.Windows.Forms.Timer(components);
            colaboradoresTimer.Tick += (_, _) =>
            {
                colaboradoresTimer.Interval = Globais.ColaboradoresTempo;
                Globais.produzirColaboradores();
            };
            Globais.InicializarMissoes();
            Globais.mudouColaboradores += (quantidade) => updateUI();
            Globais.mudouMula += (quantidade) => updateUI();
        }

        private async Task fireProgressBar()
        {
            Stopwatch cronometro = Stopwatch.StartNew();
            double tempoTotal = Globais.ProducaoTempo;

            while (cronometro.ElapsedMilliseconds < tempoTotal)
            {
                int progresso = (int)((cronometro.ElapsedMilliseconds / tempoTotal) * 100);
                progresso = Math.Clamp(progresso, 0, 100);

                if (progresso > 0)
                {
                    farmBar.Value = progresso;
                    farmBar.Value = progresso - 1;
                    farmBar.Value = progresso;
                }

                await Task.Delay(16);
            }

            farmBar.Value = 100;
            farmBar.Value = 0;
        }

        private void updateUI()
        {
            mulaLabel.Text = $"{Globais.formatarQuantidade(Globais.Bananas)} bananas";
            detalhesLabel.Text = $"{Globais.formatarQuantidade(Globais.Producao)} bananas p/produção\n" +
                $"{Globais.formatarQuantidade(Globais.Colaboradores)} colaboradores";
        }

        private async void farmarBtn_Click(object sender, EventArgs e)
        {
            farmarBtn.Enabled = false;

            await fireProgressBar();

            Globais.mudarMula(Globais.Producao);
            updateUI();
            farmarBtn.Enabled = true;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            farmBar.Value = 0;
            updateUI();
            colaboradoresTimer.Interval = Globais.ColaboradoresTempo;
            colaboradoresTimer.Start();
        }

        private void openNcloseForm<T>(ref T? form) where T : Form, new()
        {
            if (form == null || form.IsDisposed)
            {
                form = new T();
                form.Show(this);
            }
            else
            {
                form.Close();
                if (form.IsDisposed) form = null;
            }
        }

        private void missoesBtn_Click(object sender, EventArgs e)
        {
            openNcloseForm(ref missoesFormObj);
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            openNcloseForm(ref lojaFormObj);
        }
    }
}

