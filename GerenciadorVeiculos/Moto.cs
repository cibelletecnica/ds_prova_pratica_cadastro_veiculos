using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto (string modelo, decimal precoBase, int cilindradas)
            : base(modelo, precoBase)
        {
            Cilindradas = cilindradas;
        }
 
        public override decimal CalcularValorSeguro()
        {
            decimal taxaCilindradas = Cilindradas * 0.10m;
            decimal taxaBase = PrecoBase * 0.05m;
            return taxaBase + taxaCilindradas;
        }
    }
}
