using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises01
{
    public static class Alunos
    {
        public static void MaiorEMenor(int totalAlunos)
        {
            string[] nomesAlunos = new string[totalAlunos];
            double[] alturasAlunos = new double[totalAlunos];
            for (int i = 0; i < totalAlunos; i++)
            {
                Console.Write("Nome do Aluno {0}: ", i + 1);
                nomesAlunos[i] = Console.ReadLine();
                Console.Write("Altura do Aluno {0}: ", i + 1);
                double.TryParse(Console.ReadLine(), out alturasAlunos[i]);
            }

            double alturaMaiorAluno = alturasAlunos.Max();
            double alturaMenorAluno = alturasAlunos.Min();

            int indiceMaior = 0, indiceMenor = 0, c = 0;
            foreach(double altura in alturasAlunos)
            {
                if (altura == alturaMaiorAluno)
                {
                    indiceMaior = c;
                } else if (altura == alturaMenorAluno)
                {
                    indiceMenor = c;
                }
                c++;
            }
            Console.WriteLine("O maior aluno é {0} que possui {1}m", nomesAlunos[indiceMaior], alturaMaiorAluno);
            Console.WriteLine("O menor aluno é {0} que possui {1}m", nomesAlunos[indiceMenor], alturaMenorAluno);
        }
    }
}
