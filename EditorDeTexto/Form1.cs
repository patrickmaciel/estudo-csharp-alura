using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                {
                    using (StreamReader leitor = new StreamReader(entrada))
                    {
                        //string linha = leitor.ReadLine();

                        texto.Text = leitor.ReadToEnd();

                        //while (linha != null)
                        //{
                        //    texto.Text += linha;
                        //    linha = leitor.ReadLine();
                        //}

                        leitor.Close();
                        entrada.Close();
                    }

                }
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(saida))
                {
                    escritor.Write(texto.Text);
                    escritor.Close();
                    saida.Close();
                }

            }
        }
    }
}
