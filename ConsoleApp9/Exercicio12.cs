using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio12
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); // Necessário para aplicar a cor de fundo ao console inteiro

            Console.Write("Digite o número de identificação do aluno: ");
            string id = Console.ReadLine();

            Console.Write("Digite o nome do aluno(a): ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota da VAI do aluno(a): ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da VAII do aluno(a): ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da ;VAII DO aluno(A): ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a média dos exercícios do aluno(a): ");
            double ME = Convert.ToDouble(Console.ReadLine()); // ME Média de Exercicios

            double MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;
            char conceito;// o conceito nescaso sera A,B,C, PARA APROVADO e D e E PARA RERPVADO
            string mensagem;

            if (MA >= 90)
            {
                conceito = 'A';
                mensagem = "Aprovado";
            }
            else if (MA >= 75)
            {
                conceito = 'B';
                mensagem = "Aprovado";
            }
            else if (MA >= 60)
            {
                conceito = 'C';
                mensagem = "Aprovado";
            }
            else if (MA >= 40)
            {
                conceito = 'D';
                mensagem = "Reprovado";
            }
            else
            {
                conceito = 'E';
                mensagem = "Reprovado";
            }

            Console.WriteLine();

            Console.WriteLine($"Número de identificação do aluno: {id}");

            Console.WriteLine($"Nome do aluno: {nome}");

            Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");

            Console.WriteLine($"Média dos exercícios: {ME}");

            Console.WriteLine($"Média de aproveitamento: {MA}");

            Console.WriteLine($"Conceito: {conceito}");

            Console.WriteLine($"Resultado: {mensagem}");



            Console.ReadKey();

        }
    }
}
