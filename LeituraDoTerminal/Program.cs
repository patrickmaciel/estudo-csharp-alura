using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeituraDoTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            TextReader leitor = Console.In;
            string linha;
            do
            {
                linha = leitor.ReadLine();
                Console.Write("Você digitou = " + linha);
            } while (linha != null);
        }
    }
}
