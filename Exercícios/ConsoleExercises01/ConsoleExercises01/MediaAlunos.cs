using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises01
{
    public static class IdadeMediaAlunos
    {
        public static void Calcular(int numeroAlunos)
        {
            double[] idades = new double[numeroAlunos];
            for (int c = 0; c < numeroAlunos; c++)
            {
                Console.Write("Idade do Aluno {0}:", c+1);
                double.TryParse(Console.ReadLine(), out idades[c]);
            }
            double soma = 0;
            foreach (double idadeAluno in idades)
            {
                soma += idadeAluno;
            }
            double media = soma / numeroAlunos;
            Console.WriteLine("A média dos {0} alunos é {1}", numeroAlunos, media);
        }
    }
}
