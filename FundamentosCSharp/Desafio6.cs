using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    static class Desafio6
    {
        public static void Execute()
        {
            Console.WriteLine(">>> Execução do Desafio nº 6:" + Environment.NewLine);

            string desafio = "";
            while (desafio != "0")
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("Digite o número correspondente ao formado de data que deseja ver ou digite 0 para sair:" + Environment.NewLine);
                msg.Append("1: Formato completo;" + Environment.NewLine);
                msg.Append("2: Apenas a data no formato 01 / 03 / 2024;" + Environment.NewLine);
                msg.Append("3: Apenas a hora no formato de 24 horas;" + Environment.NewLine);
                msg.Append("4: A data com o mês por extenso;" + Environment.NewLine);

                Console.WriteLine(msg);

                desafio = Console.ReadLine();
                switch (desafio)
                {
                    case "0": Console.WriteLine("Saindo..."); break;
                    case "1": Console.WriteLine(DateTime.Now.ToString("dddd, dd/MM/yyyy, H:mm:ss ") + Environment.NewLine); break;
                    case "2": Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy") + Environment.NewLine); break;
                    case "3": Console.WriteLine(string.Format("{0} Horas", DateTime.Now.ToString("HH")) + Environment.NewLine ); break;
                    case "4": Console.WriteLine(string.Format("{0} de {1} de {2}", DateTime.Now.ToString("dd"), DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy") ) + Environment.NewLine); break;
                    default:
                        Console.WriteLine("Seleção inválida! Escolha entre os valores indicados;" + Environment.NewLine);
                        break;
                }
            }

            Console.WriteLine(">>> Fim da execução do Desafio nº 6" + Environment.NewLine);

        }
    }
}
