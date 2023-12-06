using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio09
    {
        public static void Executar()
        {
            Console.Write("Digite sua altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine()); // O DOUBLE e como o float o que muda são a capacidade de casas descimais onde
                                                                  // o double usa 15 casa e o float usa apenas 6

            Console.Write("Digite seu sexo (M para masculino, F para feminino): ");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper()); //A função toupper recebe como parâmetro um caracter e retorna sua versão
                                                                      //em maiúsculo enquanto a função tolower recebe um caracter como parâmetro e retorna sua versão em minúsculo
                                                                      // serve para converster o digito minusculo inserido pelo usuario para maiuculo

            double pesoIdeal;
            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo == 'F')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine($"Seu peso ideal é {pesoIdeal} kg.");
            Console.ReadKey();

        }
    }
}
