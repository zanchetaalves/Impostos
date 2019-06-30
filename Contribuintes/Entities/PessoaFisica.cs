using System.Globalization;

namespace Contribuintes.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; private set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double Impostos()
        {
            double imposto = 0L;
            if (RendaAnual < 20000L)
            {
                imposto =  RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            if (GastosComSaude > 0)
            {
                double metade = GastosComSaude / 2;
                imposto -= metade;
            }

            return imposto;
        }

        public override string ToString()
        {
            return $"{Nome}: $ {Impostos().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
