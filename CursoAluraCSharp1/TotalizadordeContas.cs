using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAB.CaixaEletronico.Contas;

namespace IAB.CaixaEletronico
{
    class TotalizadordeContas
    {
        public double Total { get; set; }

        public void Adiciona(Conta conta)
        {
            this.Total += conta.Saldo;
        }
    }
}
