using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises01
{
    public static class ReajusteSalario
    {
        public static void Calcular(int totalFuncionarios)
        {
            double[] salariosReajustados = new double[totalFuncionarios];
            for (int i = 0; i < totalFuncionarios; i++)
            {
                double salario;
                Console.Write("Salário do Funcionário {0}: ", i+1);
                double.TryParse(Console.ReadLine(), out salario);
                if (salario <= 300)
                {
                    salario *= 1.5;
                } else
                {
                    salario *= 1.3;
                }
                salariosReajustados[i] = salario;
            }

            int c = 1;
            foreach(double novoSalario in salariosReajustados)
            {
                Console.WriteLine("Novo salário do funcionário {0}: {1}", c, novoSalario);
                c++;
            }
        }
    }
}
