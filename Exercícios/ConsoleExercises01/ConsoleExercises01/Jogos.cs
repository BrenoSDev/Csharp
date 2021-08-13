using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises01
{
    public static class Jogos
    {
        public static void ParOuImpar()
        {
            int numero;
            Console.Write("Escolha um número entre 0 e 10: ");
            int.TryParse(Console.ReadLine(), out numero);
            Random aleatorio = new Random();
            int computador = aleatorio.Next(10);
            if (numero > 10 || numero < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro! Digite apenas números entre 0 e 10!");
            } else
            {
                Console.WriteLine("Digite:\n" +
                "P - para escolher par\n" +
                "I - para escolher ímpar\n");
                Console.Write("Par ou Ímpar: ");
                string escolha = Console.ReadLine().ToUpper();
                if ((escolha != "P" && escolha != "I"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas P ou I");
                } else
                {
                    int soma = numero + computador;
                    Console.WriteLine("O computador escolheu: {0}", computador);
                    string resultado = (soma % 2 != 0) ? "Ímpar" : "Par";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if ((soma % 2 != 0 && escolha == "I") || (soma % 2 == 0 && escolha == "P"))
                    {
                        Console.Write("Você ganhou pois {0} é {1}!", soma, resultado);
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu pois {0} é {1}", soma, resultado);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
