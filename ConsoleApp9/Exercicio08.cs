using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio08
    {
        public static void Executar()
        {
            Console.WriteLine("Digite três números inteiros que será ordenado de modo decrescente:");
            Console.WriteLine();
            Console.WriteLine("Digite o PRIMEIRO números inteiro:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o SEGUNDO números inteiro:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o TRECEIRO números inteiro:");
            int num3 = int.Parse(Console.ReadLine());


            int temp; // está varivel e temporaria para ordenar os números posteriormente 


            if (num1 < num2) // começa a comparação entre os númeors informado dizendo que se o numero 1 for menos que o numero 2
            {
                temp = num1;  // a temporaria recebe o n1 se for menos < que n2 ele armazena se nao ele armazena n2 na temp
                num1 = num2;
                num2 = temp;
            }

            if (num2 < num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }

            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            // Exibe os números ordenados em ordem decrescente
            Console.WriteLine("Números em ordem decrescente: " + num1 + ", " + num2 + ", " + num3);
            Console.ReadKey();

        }
    }
}
