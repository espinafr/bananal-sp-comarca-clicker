using System.Globalization;

namespace crik
{
    public static class Globais
    {
        public static int Bananas { get; set; } = 0;
        public static int Producao { get; set; } = 1323;
        public static int ProducaoTempo { get; set; } = 1000;
        public static int Colaboradores { get; set; } = 0;
        public static int ColaboradoresCusto { get; set; } = 50;
        public static int ColaboradoresTempo { get; set; } = 3000;
        
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
    }
}
