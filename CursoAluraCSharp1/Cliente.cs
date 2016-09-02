using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAB.CaixaEletronico.Usuarios
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public bool EEmancipado { get; set; }
        public string Cpf { get; set; }
        
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            return this.Idade >= 18;
        }

        public bool PodeAbrirConta()
        {
            bool maiorDeIdade = (this.Idade >= 18);
            var emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.Cpf);

            return (maiorDeIdade || emancipado) && temCpf;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente)obj;
            return this.Rg.Equals(cliente.Rg);
        }

        public override string ToString()
        {
            return this.Nome + " - " + this.Rg;
        }
    }
}
