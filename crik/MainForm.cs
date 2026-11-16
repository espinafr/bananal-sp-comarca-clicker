using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crik
{
    public partial class mainForm : Form
    {
        private MissoesForm? missoesFormObj;

        public mainForm()
        {
            InitializeComponent();
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

            Globais.ganharMula(Globais.Producao);
            updateUI();
            farmarBtn.Enabled = true;
        }

        private void mulaLabel_Click(object sender, EventArgs e)
        {
            Globais.Bananas += 1000;
            updateUI();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            farmBar.Value = 0;
            updateUI();
        }

        private void missoesBtn_Click(object sender, EventArgs e)
        {
            if (missoesFormObj == null || missoesFormObj.IsDisposed)
            {
                missoesFormObj = new MissoesForm();
                Globais.ganhouMula += missoesFormObj.ganhasteMula;
                this.FormClosed += (sender, e) => missoesFormObj?.Close();
                missoesFormObj.FormClosed += (s, args) => { Globais.ganhouMula -= missoesFormObj.ganhasteMula; missoesFormObj = null; };
                missoesFormObj.Show();
            }
            else
            {
                missoesFormObj.Close();
            }
        }
    }
}

