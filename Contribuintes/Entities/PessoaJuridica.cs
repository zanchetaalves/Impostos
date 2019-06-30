using System.Globalization;

namespace Contribuintes.Entities
{
    class PessoaJuridica : Pessoa
    {
        public short NumeroFuncionarios { get; private set; }

        public PessoaJuridica(string nome, double rendaAnual, short numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Impostos()
        {
            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }

        public override string ToString()
        {
            return $"{Nome}: $ {Impostos().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
