using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio10
    {
        public static void Executar()
        {
            Console.WriteLine("calculo de indide de massa corporal");
            Console.WriteLine();
            Console.WriteLine("Abaixo de 18, 5 Abaixo do peso");
            Console.WriteLine();
            Console.WriteLine("Entre 18,5 e 25 Peso normal");
            Console.WriteLine();
            Console.WriteLine("Entre 25 e 30 Acima do peso");
            Console.WriteLine();
            Console.WriteLine("Acima de 30 obeso");
            Console.WriteLine();
            Console.Write("Digite seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2); // formula para calculo de IMC
                                                     //Math.Pow(altura, 2): Esta é uma função em C# que eleva o primeiro argumento (altura) à potência do segundo argumento (2).
                                                     //Então,Math.Pow(altura, 2) resultará no quadrado da altura.

            if (imc < 18.5)
            {
                Console.WriteLine("sua masa é: " + imc + "abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25) // OBS. para me lembrar depois, os && quer dizer E no caso maior igual 18.5 "E" menor que 25
            {
                Console.WriteLine("sua masa é: " + imc + "Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("sua masa é: " + imc + "Acima do peso");
            }
            else
            {
                Console.WriteLine("sua masa é: " + imc + "Obeso");
                Console.ReadKey();

            }
        }
    }
}
