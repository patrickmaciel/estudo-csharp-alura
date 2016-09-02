using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAB.CaixaEletronico.Contas;

namespace IAB.CaixaEletronico
{
    class ContaCorrente: Conta
    {
        public static int TotalDeContas { get; set; }

        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
        }

        public static int ProximoNumero()
        {
            return ContaCorrente.TotalDeContas + 1;
        }

        public override void Saca(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }

            if (this.Saldo >= valor)
            {
                this.Saldo -= valor + 0.1;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}
