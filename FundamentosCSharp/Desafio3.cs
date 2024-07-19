using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    static class Desafio3
    {
        public static void Execute()
        {
            Console.WriteLine(">>> Execução do Desafio nº 3:");
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Soma(valor1, valor2);
            Subtração(valor1, valor2);
            Multiplicação(valor1, valor2);
            Divisão(valor1, valor2);
            Media(valor1, valor2);

            Console.WriteLine(">>> Fim da execução do Desafio nº 3" + Environment.NewLine);

        }

        public static void Soma(int valor1, int valor2)
        {
            Console.WriteLine("--> SOMA: " + (valor1 + valor2));
        }

        public static void Subtração(int valor1, int valor2)
        {
            Console.WriteLine("--> SUBTRAÇÃO: " + (valor1 - valor2));
        }

        public static void Multiplicação(int valor1, int valor2)
        {
            Console.WriteLine("--> MULTIPLICAÇÃO: " + (valor1 * valor2));
        }

        public static void Divisão(int valor1, int valor2)
        {
            if (valor2==0)
            {
                Console.WriteLine("--> DIVISÃO ERRO: Divião por zero é inválida!");
            }
            else
            {
                Console.WriteLine("--> DIVISÃO: " + (valor1 / valor2));
            }
        }

        public static void Media(double valor1, double valor2)
        {
            var result = (valor1 + valor2)/2;
            Console.WriteLine("--> MÉDIA: " + result);
        }
    }
}
