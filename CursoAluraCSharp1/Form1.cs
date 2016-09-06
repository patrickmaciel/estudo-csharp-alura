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
    public partial class Form1 : Form
    {
        private Conta conta;
        private Conta[] contas;
        private int quantidadeContas = 0;

        private BindingSource bs;
        private BindingList<Conta> _contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Código do primeiro curso */

            /*
            Conta contaGuilherme = new Conta();
            contaGuilherme.Numero = 1;
            contaGuilherme.Deposita(1500.0);

            Cliente clienteGuilherme = new Cliente("Guilherme");
            clienteGuilherme.Idade = 18;

            contaGuilherme.Titular = clienteGuilherme;

            bool sacou = contaGuilherme.Saca(300.0);//testando idade
            if (sacou)
            {
                MessageBox.Show("Saldo Conta do Guilherme apos saque de 300: " + contaGuilherme.Saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do Guilherme");
            }
            */

            /* Código do segundo curso */
            /*
            ContaPoupanca cp = new ContaPoupanca();
            Cliente patrick = new Cliente("Patrick");
            patrick.Idade = 25;
            cp.Titular = patrick;

            cp.Deposita(1000);
            cp.Saca(100);

            MessageBox.Show("Saldo Poupança " + cp.Saldo);

            Conta c = new Conta();
            c.Deposita(100);
            MessageBox.Show("Saldo da conta: " + c.Saldo);

            Conta c1 = new Conta();
            c1.Deposita(10);

            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(100);

            TotalizadordeContas t = new TotalizadordeContas();
            t.Adiciona(c1);
            t.Adiciona(c2);

            MessageBox.Show("O total é: " + t.Total);
            

            int[] numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 200;
            numeros[2] = 312;
            numeros[3] = -4;
            numeros[4] = 512;

            Conta[] contas = new Conta[2];
            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            for (int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show("O saldo da conta é: " + contas[i].Saldo);
            }

            foreach (Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta é: " + conta.Saldo);
            }
            */

            /* Equals e toString()
            Cliente cliente1 = new Cliente("Patrick");
            cliente1.Rg = "1234-5";

            Cliente cliente2 = new Cliente("Patrick");
            cliente2.Rg = "1234-5";

            MessageBox.Show("Iguais? " + cliente1.Equals(cliente2));
            MessageBox.Show("Cliente toString() " + cliente1.ToString());
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Ex1
            Conta conta = new Conta();
            conta.Titular = new Cliente("Patrick");
            textoTitular.Text = conta.Titular.Nome;
            */

            // Ex2
            this.contas = new Conta[20];
            this.contas[0] = new ContaCorrente();
            this.contas[0].Numero = 1;
            this.contas[0].Titular = new Cliente("Patrick");

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Numero = 2;
            this.contas[1].Titular = new Cliente("Maciel");

            // comboContas.Items.Add(contas[0].Titular.Nome);
            // comboContas.Items.Add(contas[1].Titular.Nome);

            _contas = new BindingList<Conta>();
            foreach (Conta conta in this.contas)
            {
                if (conta != null)
                {
                    Console.WriteLine(conta.Titular.Nome);
                    _contas.Add(conta);
                    //comboContas.Items.Add(conta.Titular.Nome);
                    this.quantidadeContas++;
                }
            }

            bs = new BindingSource();
            bs.DataSource = _contas;

            comboContas.DisplayMember = "Titular";
            //comboContas.ValueMember = "Titular.Nome";
            comboContas.Format += (s, formatObject) =>
            {
                formatObject.Value = ((Cliente)formatObject.Value).Nome;
            };
            comboContas.DataSource = bs;
            //comboContas.DataSource = _contas;

            // C#2 Ex3
            ContaCorrente c1= new ContaCorrente();
            // MessageBox.Show("Total: " + ContaCorrente.TotalDeContas);
            ContaCorrente c2 = new ContaCorrente();
            labelTotalContas.Text = Convert.ToString(ContaCorrente.TotalDeContas);
            // MessageBox.Show("Total: " + ContaCorrente.TotalDeContas);
            // MessageBox.Show("Próximo " + ContaCorrente.ProximoNumero());

            this.conta = new ContaCorrente();
            this.conta.Numero = 2;
            this.conta.Titular = new Cliente("Patrick Maciel");
            this.conta.Deposita(3284);
            saldoConta.Text = Convert.ToString(this.conta.Saldo);

            /* 38% - tópicos avançados 
            var contas = new List<Conta>();

            var c3 = new ContaCorrente();
            c3.Numero = 1;
            c3.Titular = new Cliente("Patrick");

            contas.Add(c3);
            Conta copiaC1 = contas[0];

            var c4 = new ContaCorrente();
            c4.Numero = 2;
            c4.Titular = new Cliente("Victor");

            MessageBox.Show("Está lá: " + contas.Contains(c3));
            MessageBox.Show("Esta lá: " + contas.Contains(c4));

             * contas.Remove(object);
             * contas.RemoveAt(index);
             * contas.Count;
            */

            /* 47% - tópicos avançados
            var contas = new HashSet<Conta>();

            var c5 = new ContaCorrente();
            c5.Numero = 1;
            c5.Titular = new Cliente("Patrick");
            
            var c6 = new ContaCorrente();
            c6.Numero = 2;
            c6.Titular = new Cliente("Victor");

            contas.Add(c5);
            contas.Add(c6);

            foreach (var c in contas)
            {
                MessageBox.Show(c.Titular.Nome);
            }*/

            /* 51% - tópicos avançados 
            SortedSet<string> palavras = new SortedSet<string>();
            palavras.Add("vida");
            palavras.Add("furadeira");
            palavras.Add("maçã");

            foreach (var p in palavras)
            {
                MessageBox.Show(p);
            }

            Dictionary<string, string> nomeEPalavras = new Dictionary<string, string>();
            nomeEPalavras.Add("Erich", "vida");
            nomeEPalavras.Add("Alberto", "delicia");
            MessageBox.Show(nomeEPalavras["Erich"]);
            */


        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double valorSaque = Convert.ToDouble(textoValorSaque.Text);

            try
            {
                this.conta.Saca(valorSaque);
                MessageBox.Show("Dinheiro liberado");
            }
            catch (SaldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor inválido pra o saque");
            }
            
            saldoConta.Text = Convert.ToString(this.conta.Saldo);
        }

        public void AdicionaConta(Conta conta)
        {
            if (this.quantidadeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.quantidadeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.quantidadeContas] = conta;
            this.quantidadeContas++;
            comboContas.Items.Add(conta);

            // this.contas[this.quantidadeContas] = conta;
            // comboContas.Items.Add(conta.Titular.Nome);
            // this.quantidadeContas++;
        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            CadastrodeContas cadastro = new CadastrodeContas(this);
            cadastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int indiceSelecionado = comboContas.SelectedIndex;
            //Conta contaSelecionada = contas[indiceSelecionado];

            //textoTitular.Text = contaSelecionada.Titular.Nome;
            //textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            //textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

            int indiceSelecionado = comboContas.SelectedIndex;
            Conta selecionada = contas[indiceSelecionado];
            //_contas.ResetItem(indiceSelecionado);
            _contas.RemoveAt(indiceSelecionado);

            //comboContas.Items.Remove(selecionada);
            //int i;
            //for (i = 0; i < this.quantidadeContas; i++)
            //{
            //    if (this.contas[i] == selecionada)
            //    {
            //        break;
            //    }
            //}
            //while (i + 1 < this.quantidadeContas)
            //{
            //    this.contas[i] = this.contas[i + 1];
            //    i++;
            //}

            // comboContas.DataSource = comboContas.Items;
            // comboContas.Refresh();
            //comboContas.EndUpdate();
            // MessageBox.Show(selecionada.Titular.Nome);
        }
    }
}
