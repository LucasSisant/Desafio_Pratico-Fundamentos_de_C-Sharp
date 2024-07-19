using System;
using System.Text;
namespace FundamentosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string desafio = "";
            while (desafio != "0")
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("Digite o número correspondente ao desafio para executá-lo ou digite 0 para sair:" + Environment.NewLine);
                msg.Append("1: Mensagem de boas vindas;" + Environment.NewLine);
                msg.Append("2: Concatena Nome e Sobrenome;" + Environment.NewLine);
                msg.Append("3: Operações matematicas;" + Environment.NewLine);
                msg.Append("4: Contador de caracteres;" + Environment.NewLine);
                msg.Append("5: Verificar placa automotiva;" + Environment.NewLine);
                msg.Append("6: Calendário." + Environment.NewLine);

                Console.WriteLine(msg);
                desafio = Console.ReadLine();
                switch (desafio)
                {
                    case "0": Console.WriteLine("Saindo..."); break;
                    case "1": Desafio1.Execute(); break;
                    case "2": Desafio2.Execute(); break;
                    case "3": Desafio3.Execute(); break;
                    case "4": Desafio4.Execute(); break;
                    case "5": Desafio5.Execute(); break;
                    case "6": Desafio6.Execute(); break;
                    default:
                        Console.WriteLine("Seleção inválida! Escolha entre os valores indicados;" + Environment.NewLine);
                        break;
                }
            }
        }
    }
}







