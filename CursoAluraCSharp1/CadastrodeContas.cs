using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAB.CaixaEletronico.Usuarios;
using IAB.CaixaEletronico.Contas;

namespace IAB.CaixaEletronico
{
    public partial class CadastrodeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        private String[] tipoConta;

        public CadastrodeContas(Form1 aplicacaoPrincipal)
        {
            this.tipoConta = new String[2];
            tipoConta[0] = "Corrente";
            tipoConta[1] = "Corrente";

            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titular = titularConta.Text;
            int numero = Convert.ToInt32(numeroConta.Text);
            string tipoConta = Convert.ToString(comboTipoConta.SelectedItem);
            Conta conta;

            if (tipoConta == "Corrente")
            {
                conta = new ContaCorrente()
                {
                    Numero = numero,
                    Titular = new Cliente(titular)
                };
            }
            else
            {
                conta = new ContaPoupanca()
                {
                    Numero = numero,
                    Titular = new Cliente(titular)
                };
            }
            
            this.aplicacaoPrincipal.AdicionaConta(conta);
        }

        private void CadastrodeContas_Load(object sender, EventArgs e)
        {
            foreach (String tipoConta in this.tipoConta)
            {
                comboTipoConta.Items.Add(tipoConta);
            }
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
