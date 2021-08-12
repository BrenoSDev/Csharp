using System;

namespace AdivinheUmNumero
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Adivinhe um número de 0 a 100!");
            Console.WriteLine("Você tem 10 tentativas!");
            Random ObjetoAleatorio = new Random();
            int aleatorio = ObjetoAleatorio.Next(100);
            int tentativa = 0;
            while (tentativa <= 10)
            {
                Console.WriteLine("=================================");
                Console.Write("Tentativa: ");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == aleatorio)
                {
                    Console.WriteLine("Você acertou! Parabéns!");
                    Console.WriteLine("Você acertou em " + tentativa + " tentativas");
                    break;
                }
                else
                {
                    if (escolha > aleatorio)
                    {
                        Console.WriteLine("O valor é menor!");
                    }
                    else
                    {
                        Console.WriteLine("O valor é maior!");
                    }
                }
                tentativa++;
            }
            if (tentativa == 10)
            {
                Console.WriteLine("Suas tentativas acabaram!!!");
                Console.WriteLine("O número correto era: " + aleatorio);
            }
        }
    }
}
