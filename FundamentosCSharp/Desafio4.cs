using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    static class Desafio4
    {
        public static void Execute()
        {
            Console.WriteLine(">>> Execução do Desafio nº 4:");
            Console.WriteLine("Digite uma ou mais palavras:");
            string[] palavras = Console.ReadLine().Split(' ');
            foreach (var item in palavras)
            {
                Console.WriteLine(string.Format("A palavra {0} possui: {1} caracteres.", item, item.Count()));

            }
            Console.WriteLine(">>> Fim da execução do Desafio nº 4" + Environment.NewLine);

        }
    }
}
