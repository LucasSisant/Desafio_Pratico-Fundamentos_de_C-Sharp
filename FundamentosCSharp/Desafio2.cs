using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    static class Desafio2
    {
        public static void Execute()
        {
            Console.WriteLine(">>> Execução do Desafio nº 2:");
            Console.WriteLine("Digite o seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine(String.Format("Nome completo: {0} {1}", nome, sobrenome));
            Console.WriteLine(">>> Fim da execução do Desafio nº 2" + Environment.NewLine);
        }
    }
}
