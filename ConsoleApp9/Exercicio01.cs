using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("INFORME O VALOR DE A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME O VALOR DE B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME O VALOR DE C");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b;

            if (soma < c)
            
            {

                Console.WriteLine("A soma de A + B é menor que o valor de C");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que o valor de C");
            }


            Console.ReadKey();
        }
    }
}
