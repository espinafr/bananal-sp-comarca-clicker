using System.Globalization;

namespace crik
{
    public static class Globais
    {
        // variáveis
        public static int Bananas { get; set; } = 0;
        public static int Producao { get; set; } = 1323;
        public static int ProducaoTempo { get; set; } = 1000;
        public static int Colaboradores { get; set; } = 0;
        public static int ColaboradoresCusto { get; set; } = 50;
        public static int ColaboradoresTempo { get; set; } = 3000;

        // eventos
        public static event Action<int>? mudouMula;
        public static void mudarMula(int quantidade)
        {
            Bananas += quantidade;
            fireMissoes?.Invoke();
            mudouMula?.Invoke(Bananas);
        }
        public static event Action? fireMissoes; // nada é mais eterno que o temporário

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
    }
}
