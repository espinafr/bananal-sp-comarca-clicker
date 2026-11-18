using System.Globalization;

namespace crik
{
    public static class Globais
    {
        public static System.ComponentModel.BindingList<Missao> Missoes { get; } = new();
        private static bool missoesInicializadas;

        public static void InicializarMissoes()
        {
            if (missoesInicializadas) return;
            missoesInicializadas = true;
            AdicionarMissao();
        }

        // variáveis
        public static int Bananas { get; set; } = 0;
        public static int Producao { get; set; } = 1323;
        public static int ProducaoTempo { get; set; } = 1000;
        public static int Colaboradores { get; set; } = 0;
        public static float ColaboradoresTaxaAumento { get; set; } = 0.1f;
        public static int ColaboradoresCusto { get; set; } = 50;
        public static int ColaboradoresTempo { get; set; } = 5000;
        public static int ColaboradoresProducao { get; set; } = 1;

        // eventos
        public static event Action<int>? mudouMula;
        public static event Action<int>? mudouProducao;
        public static event Action<int>? mudouColaboradores;
        public static event Action? fireMissoes; // nada é mais eterno que o temporário
        public static void mudarMula(int quantidade)
        {
            Bananas += quantidade;
            fireMissoes?.Invoke();
            mudouMula?.Invoke(Bananas);
        }
        public static void produzirColaboradores()
        {
            int quantidade = Colaboradores * ColaboradoresProducao;
            if (quantidade > 0) mudarMula(quantidade);
        }

        public static bool comprar(int custo, Action? aoComprar = null)
        {
            if (custo < 0) throw new ArgumentOutOfRangeException(nameof(custo));
            if (Bananas < custo) return false;

            Bananas -= custo;
            aoComprar?.Invoke();
            mudouMula?.Invoke(-custo);
            fireMissoes?.Invoke();
            return true;
        }
        public static bool comprarColaboradores(int quantidade, int custo)
        {
            if (quantidade <= 0) throw new ArgumentOutOfRangeException(nameof(quantidade));

            return comprar(custo, () =>
            {
                Colaboradores += quantidade;
                mudouColaboradores?.Invoke(quantidade);
            });
        }
        // funções
        public static string formatarQuantidade(int quantidade)
        {
            if (quantidade < 1000)
                return quantidade.ToString();

            string[] sufixos = { "", "mil", "milhões de", "bilhões de", "trilhões de" };

            int indice = (int)Math.Floor(Math.Log10(quantidade) / 3);

            indice = Math.Min(indice, sufixos.Length - 1);

            double valorReduzido = quantidade / Math.Pow(1000, indice);
            string numeroFormatado = valorReduzido.ToString("0.#", new CultureInfo("pt-BR"));

            return $"{numeroFormatado} {sufixos[indice]}";
        }

        public static void autoEscalar(this Control controle, float tamanhoMaximo, float tamanhoMinimo = 6f, bool wrap = true)
        {
            if (string.IsNullOrEmpty(controle.Text) || controle.ClientSize.Width <= 0 || controle.ClientSize.Height <= 0)
                return;

            Size availableSize = new Size(
                controle.ClientSize.Width - controle.Padding.Horizontal,
                controle.ClientSize.Height - controle.Padding.Vertical
            );

            TextFormatFlags flags = wrap ? TextFormatFlags.WordBreak : TextFormatFlags.SingleLine;
            float currentSize = tamanhoMaximo;

            while (currentSize > tamanhoMinimo)
            {
                using (Font testFont = new Font(controle.Font.FontFamily, currentSize, controle.Font.Style))
                {
                    Size measuredSize = TextRenderer.MeasureText(controle.Text, testFont, availableSize, flags);

                    if (measuredSize.Width <= availableSize.Width && measuredSize.Height <= availableSize.Height)
                    {
                        break;
                    }
                }
                currentSize -= 0.5f;
            }

            if (Math.Abs(controle.Font.Size - currentSize) > 0.01f)
            {
                controle.Font = new Font(controle.Font.FontFamily, Math.Max(currentSize, tamanhoMinimo), controle.Font.Style);
            }
        }
        public static void AdicionarMissao(int meta = 200, int dificuldade = 0)
        {
            int recompensa = meta / 3;
            Missao? missao = null;
            missao = new Missao(
                $"guardando bananas{(dificuldade > 0 ? $" {dificuldade + 1}" : "")}",
                $"Junte {formatarQuantidade(meta)} bananas.",
                recompensa, dificuldade,
                () => Bananas >= meta,
                () =>
                {
                    //Missoes.Remove(missao!);
                    //missao!.Dispose();
                    mudarMula(recompensa);

                    double proximaMeta = Math.Ceiling(Math.Pow(meta, 1.5));
                    if (proximaMeta <= int.MaxValue)
                        AdicionarMissao((int)proximaMeta, Math.Min(dificuldade + 1, 5));
                });
            Missoes.Insert(0, missao);
        }
        public static int corrigirOffset(Label labelObj, int direita)
        {
            return direita - labelObj.Width;
        }
    }
}
