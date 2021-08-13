using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises01
{
    public static class VerificadorDeIdade
    {
        public static void Verificar(int pessoas)
        {
            int[] idades = new int[pessoas];
            for (int i = 0; i < pessoas; i++)
            {
                Console.Write("Idade da pessoa {0}: ", i + 1);
                int idade;
                int.TryParse(Console.ReadLine(), out idade);
                idades[i] = idade;
            }
            int maiorIdade = idades.Max();
            int menorIdade = idades.Min();
            double mediaIdades = idades.Average();
            int maioresDeIdade = 0;
            foreach (int idade in idades)
            {
                if (idade >= 18)
                {
                    maioresDeIdade++;
                }
            }
            Console.WriteLine("Informações:\n" +
                "Maiores de Idade: {0}\n" +
                "Maior Idade: {1}\n" +
                "Menor Idade: {2}\n" +
                "Média de Idades: {3}\n", maioresDeIdade, maiorIdade, menorIdade, mediaIdades);
        }
    }
}
