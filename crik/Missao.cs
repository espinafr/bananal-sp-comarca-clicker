namespace crik
{
    public sealed class Missao : IDisposable
    {
        public string Titulo { get; }
        public string Descricao { get; }
        public int Recompensa { get; }
        public int Dificuldade { get; }
        public bool Completed { get; private set; }
        public event Action? Concluida;

        private readonly Func<bool> validador;
        private readonly Action recompensador;
        private bool descartada;

        public Missao(string titulo, string descricao, int recompensa, int dificuldade, Func<bool> validador, Action recompensador)
        {
            Titulo = titulo;
            Descricao = descricao;
            Recompensa = recompensa;
            Dificuldade = dificuldade;
            this.validador = validador ?? throw new ArgumentNullException(nameof(validador));
            this.recompensador = recompensador ?? throw new ArgumentNullException(nameof(recompensador));
            Globais.fireMissoes += Verificar;
        }

        public void Verificar()
        {
            if (descartada || Completed || !validador()) return;

            Completed = true;
            Globais.fireMissoes -= Verificar;
            Concluida?.Invoke();
            recompensador();
        }

        public void Dispose()
        {
            descartada = true;
            Globais.fireMissoes -= Verificar;
        }
    }
}
