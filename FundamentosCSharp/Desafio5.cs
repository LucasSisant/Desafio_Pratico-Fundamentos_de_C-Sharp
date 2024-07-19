using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    static class Desafio5
    {
        public static void Execute()
        {
            Console.WriteLine(">>> Execução do Desafio nº 5:");
            Console.WriteLine("Digite a placa para verificar:");
            string placa = Console.ReadLine();
            if (placa.Count() == 7)
            {
                int number = 0;
                for (int i = 0; i < 3; i++)
                {
                    var isNumber = int.TryParse(placa[i].ToString(), out number);
                    if (isNumber)
                    {
                        Console.WriteLine("FALSO: Os 3 primeiros caracteres devem ser letras");
                        break;
                    }
                }

                for (int i = 3; i < 7; i++)
                {
                    var isNumber = int.TryParse(placa[i].ToString(), out number);
                    if (!isNumber)
                    {
                        Console.WriteLine("FALSO: Os 4 ultimos caracteres devem ser numeros");
                        break;
                    }
                }
                Console.WriteLine("VERDADEIRO: A placa informada atende ao padrão brasileiro");

            }
            else
            {
                Console.WriteLine("FALSO: Quantidade de caracteres inválido");
            }
            Console.WriteLine(">>> Fim da execução do Desafio nº 5" + Environment.NewLine);

        }
    }
}
