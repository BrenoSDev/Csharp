using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosMatematicos
{
    public static class Formulas
    {
        public static string ParOuImpar(int valor)
        {
            if (valor % 2 == 0)
            {
                return "Par";
            }
            else
            {
                return "Ímpar";
            }
        }
        public static void Calculadora()
        {
            double valor1, valor2, resultado = 0;
            Console.Write("Digite um valor: ");
            double.TryParse(Console.ReadLine(), out valor1);
            Console.Write("Digite outro valor: ");
            double.TryParse(Console.ReadLine(), out valor2);
            string menuOperacoes = "\nMenu operações:" +
                                    "\n+ Para Somar" +
                                    "\n- Para Subtrair" +
                                    "\nx Para multiplicar" +
                                    "\n/ Para dividir\n";
            Console.WriteLine(menuOperacoes);
            Console.Write("Operação: ");
            char opcao;
            char.TryParse(Console.ReadLine(), out opcao);
            bool calcular = true;
            if (opcao == '+')
            {
                resultado = valor1 + valor2;
            } else if (opcao == '-')
            {
                resultado = valor1 - valor2;
            } else if (opcao == 'x')
            {
                resultado  = valor1 * valor2;
            } else if (opcao == '/')
            {
                if (valor2 != 0)
                {
                    resultado  = valor1 / valor2;
                } else
                {
                    Console.WriteLine("Não se pode dividir por 0!!");
                    resultado = 0;
                    calcular = false;
                }
            } else
            {
                Console.WriteLine("Opção incorreta! Digite uma opção válida!");
                resultado = 0;
                calcular = false;
            }

            if (calcular)
            {
                Console.WriteLine("{0} {1} {2} = {3}", valor1, opcao, valor2, resultado);
            }            
        }

        public static double ReajusteSalario(double salario)
        {
            if (salario <= 1700)
            {
                return salario + 300;
            } else
            {
                return salario + 200;
            }
        }

        public static double CalculoImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}
