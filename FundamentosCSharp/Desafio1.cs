using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    static class Desafio1
    {

        public static void Execute()
        {
            Console.WriteLine(">>> Execução do Desafio nº 1:");
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine(String.Format("Olá, [0]! Seja muito bem-vindo!", nome + Environment.NewLine));
            Console.WriteLine(">>> Fim da execução do Desafio nº 1" + Environment.NewLine);

        }
    }
}
