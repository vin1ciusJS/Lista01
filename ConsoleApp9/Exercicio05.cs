using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio05
    {
        public static void Executar()
        {
            Console.WriteLine("informar o número, se negativo será mutiplicado por 3 se positvo por 2");
            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();

            Console.WriteLine("Informe o um NÚMERO aleatorio");
            Console.WriteLine();

            int a = int.Parse(Console.ReadLine());
            // declarado apenas uma varial pois a mesma será multiplicada ou triplicada
            //de acordo com o número unformado 


            Console.WriteLine();
            if (a >= 0)
            // quando vai usar menor igual ou maior igual declara >= ou <= 
            //no caso de usar um número igual a outro usa ==

            {
                a = a * 2;

            }

            else
            {

                a = a * 3;
            }
            Console.WriteLine("o resultado do número digitado é: " + a);
            // o sinal de soma (+) dentro dos (parenteses) seguito da varial
            // a mostra no PRINT quando ela fica entre duas frazes usa +variavel+ com o sinal de + nos dois lados da variavel 

            Console.WriteLine();

            Console.WriteLine("******************************************************************************");

            Console.ReadKey();

        }
    }
}
