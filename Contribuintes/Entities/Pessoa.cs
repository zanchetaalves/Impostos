namespace Contribuintes.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; private set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Impostos();
    }
}
