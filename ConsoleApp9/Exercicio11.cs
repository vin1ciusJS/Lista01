using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Exercicio11
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o nome do produto que esta comprando");
            string produto = Console.ReadLine();

            double precoNormal;
            while (true)
            {
                Console.Write("Digite o preço normal do produto: ");
                if (double.TryParse(Console.ReadLine(), out precoNormal))
                {
                    break;
                }
                Console.WriteLine("Por favor, insira um número válido.");
            }

            Console.WriteLine("\nCondição de pagamamento! \n1 - DINHEIRO OU CHEQUE 10% DE DESCONTO \n2 - Cartão de CREDITO 15% DESCONTO");
            Console.WriteLine("3 - Em DUAS VEZES preço normal \n4 - Acima de Duas vezes 10% a mais no valor\n");

            int codigo;
            while (true)
            {
                Console.Write("Digite o código da condição de pagamento (1, 2, 3, ou 4): ");  // validação caso usuario digite outro codigo
                if (int.TryParse(Console.ReadLine(), out codigo) && codigo >= 1 && codigo <= 4) // condição o de 1 a 4 que são as opçoes e o ENQUANTO
                {
                    break;
                }
                Console.WriteLine("Por favor, insira um número válido entre 1 e 4.");
            }

            double precoFinal;

            switch (codigo)
            {
                case 1:
                    precoFinal = precoNormal * 0.9; //  de a cordo com a opção desconto de 10%
                    break;
                case 2:
                    precoFinal = precoNormal * 0.85; //de a cordo com a opção desconto de 15%
                    break;
                case 3:
                    precoFinal = precoNormal; // de a cordo com a opção sem juros
                    break;
                case 4:
                    precoFinal = precoNormal * 1.1; // de a cordo com a opção juros de 10%
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    return;
            }

            Console.WriteLine($"\nO preço final do produto: {produto} é de R$ {precoFinal:F2}");
            Console.ReadKey();

        }
    }
}
