using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio04
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o valor de A ");
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o valor de B ");
            Console.WriteLine();
            int b = int.Parse(Console.ReadLine());

            int c; // variavel vazia para recer o valor de A*B se diferente ou A+B se iguais 

            if (a == b)
            {
                c = a + b; // este campo quer dizer que se A e B forem iguais a variavel C irá recber a soma de A+B
            }
            else
            {
                c = a * b; // esta campo semelhante ao anterior se A for diferente de B a variavel C vai receber A * B
            }
            Console.WriteLine("______________________________________________________");

            Console.WriteLine("O resultado e dos dois númeoros informado é: " + c);

            Console.WriteLine("______________________________________________________");

            Console.ReadKey();

        }
    }
}
