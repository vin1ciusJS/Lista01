using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro valor booleano (true/false):");
            Boolean valor1 = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor booleano (true/false):");
            Boolean valor2 = Boolean.Parse(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS (true).");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos os valores são FALSOS (false).");
            }
            else
            {
                Console.WriteLine("Um dos valores é VERDADEIRO (true) e o outro é FALSO (false).");
            }

            Console.ReadKey();

        }
    }
}
