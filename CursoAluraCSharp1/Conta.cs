using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAB.CaixaEletronico.Usuarios;

namespace IAB.CaixaEletronico.Contas
{
    // Definindo a classe como abstrata você impede ela de ser instanciada
    public abstract class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        //atributos agencias e cpf omitidos

        public void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado >= 0)
            {
                this.Saldo += valorASerDepositado;
            }
        }

        // Marcando um método como abstratado você força as classes filhas a instanciarem ele
        public abstract void Saca(double valor);
        // public abstract bool Saca(double valor);
        /* public virtual void Saca(double valor);
            // Inicio Código do curso 1 

            if (valorASerSacado > this.Saldo || valorASerSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valorASerSacado;
                    return true;
                }
                else
                {
                    if (valorASerSacado <= 200)
                    {
                        this.Saldo -= valorASerSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            
            this.Saldo -= valor;
        } */

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }
    }
}
