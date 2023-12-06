using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opcao = "";
            while (opcao != "x")
            {
                Console.WriteLine("Menu de Atividades - Lista 1");
                Console.WriteLine("");
                Console.WriteLine("1 - Exercicio 1");
                Console.WriteLine("2 - Exercicio 2");
                Console.WriteLine("3 - Exercicio 3");
                Console.WriteLine("4 - Exercicio 4");
                Console.WriteLine("5 - Exercicio 5");
                Console.WriteLine("6 - Exercicio 6");
                Console.WriteLine("7 - Exercicio 7");
                Console.WriteLine("8 - Exercicio 8");
                Console.WriteLine("9 - Exercicio 9");
                Console.WriteLine("10 - Exercicio 10");
                Console.WriteLine("11 - Exercicio 11");
                Console.WriteLine("12 - Exercicio 12");
                Console.WriteLine("X - Fechar o Programa");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine().ToUpper();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Exercicio01.Executar();
                        break;
                    case "2":
                        Exercicio02.Executar();
                        break;
                    case "3":
                        Exercicio03.Executar();
                        break;
                    case "4":
                        Exercicio04.Executar();
                        break;
                    case "5":
                        Exercicio05.Executar();
                        break;
                    case "6":
                        Exercicio06.Executar();
                        break;
                    case "7":
                        Exercicio07.Executar();
                        break;
                    case "8":
                        Exercicio08.Executar();
                        break;
                    case "9":
                        Exercicio09.Executar();
                        break;
                    case "10":
                        Exercicio10.Executar();
                        break;
                    case "11":
                        Exercicio11.Executar();
                        break;
                    case "12":
                        Exercicio12.Executar();
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("Finalizando Código");
                        return;
                    default:
                        Console.WriteLine("Opção Inválida. Digite outra");
                        break;
                }
            } while (true) ;
        }
    }
}
