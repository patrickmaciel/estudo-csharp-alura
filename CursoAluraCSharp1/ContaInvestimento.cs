using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAB.CaixaEletronico.Contas;

namespace IAB.CaixaEletronico
{
    class ContaInvestimento : Conta, Tributavel
    {
        public override void Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.1;
            }
            else
            {
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
