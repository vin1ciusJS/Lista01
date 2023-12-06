using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio07
    {
        public static void Executar()
        {
            Console.WriteLine("Faça um algoritmo que some 5 caso seja par e caso seja ímpar some 8.");
            Console.WriteLine();
            Console.WriteLine("Digite um número aleatório:");
            int N1 = int.Parse(Console.ReadLine());

            int resultado; // Variável que mostrará a soma entre o número digitado e a soma de 5 ou 8

            switch (N1 % 2)
            {
                case 0:
                    resultado = N1 + 5;
                    break;
                case 1:
                    resultado = N1 + 8;
                    break;
                default:
                    resultado = N1; // Tratamento para outros valores, não estritamente par ou ímpar.
                    break;
            }

            Console.WriteLine("O resultado é: " + resultado);

        }
    }
}
