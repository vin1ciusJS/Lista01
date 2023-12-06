using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("informe um número para saber se é PAR OU IMPAR");
            Console.WriteLine("");
            Console.WriteLine("informe o Número");
            int numero = int.Parse(Console.ReadLine());


            // a porcentagem ira servir para comparar se o resto da divizao e igual a zero para ele definir se é par
            // caso contratio será impar

            if (numero % 2 == 0)

            {
                Console.WriteLine($"o numero  {numero}  Digitado é um Numero PAR");

            }

            else
            {
                Console.WriteLine("o número  " + numero + "  digitado é IMPAR");
            }
            Console.ReadKey();

        }
    }
}
