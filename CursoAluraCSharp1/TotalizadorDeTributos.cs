using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAB.CaixaEletronico
{
    class TotalizadorDeTributos
    {
        public double Total { get; set; }

        public void Acumula(Tributavel tributavel)
        {
            this.Total += tributavel.CalculaTributo();
        }
    }
}
