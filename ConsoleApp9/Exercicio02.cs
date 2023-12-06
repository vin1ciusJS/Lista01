using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Informe seu NOME COMPLETO:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe seu sexo SENDO F para feminino,OU  M para masculino:");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe seu estado civil SENDO C para casado(a), OU S para solteiro(a)):");
            string estado_civil = Console.ReadLine();

            //QUANDO TEM IF abre e fecha chave sinalizando que encerrou esta parte para não gerar conflito.
            if (sexo == "F" && estado_civil == "C")
            {
                Console.WriteLine("Informe o tempo de casado:");
                string tempoCasado = Console.ReadLine();
                Console.WriteLine($"Você é uma mulher casada há {tempoCasado} anos.");
            }


            Console.ReadKey();

        }
    }
}
