using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nO que você deseja fazer?\n" +
                    "0 - Sair do Programa\n" +
                    "1 - Calcular média de alunos\n" +
                    "2 - Jogo Par ou Ímpar\n" +
                    "3 - Verificador de Idade\n" +
                    "4 - Reajuste de Salário\n" +
                    "5 - Maior e menor aluno\n");
                Console.Write("Opção escolhida: ");
                string opcaoMenu = Console.ReadLine();
                Console.WriteLine("\n");
                if (opcaoMenu == "0")
                {
                    break;
                }
                else if (opcaoMenu == "1")
                {
                    int nAlunos;
                    Console.Write("Digte o número de alunos para calcularmos a média de idade deles: ");
                    int.TryParse(Console.ReadLine(), out nAlunos);
                    IdadeMediaAlunos.Calcular(nAlunos);
                } else if (opcaoMenu == "2")
                {
                    Console.WriteLine("Vamos jogar par ou ímpar!");
                    Jogos.ParOuImpar();
                } else if (opcaoMenu == "3")
                {
                    Console.WriteLine("Verificador de idades");
                    Console.Write("Qual a quantidade de pessoas para verificar a idade: ");
                    int totalPessoas;
                    int.TryParse(Console.ReadLine(), out totalPessoas);
                    VerificadorDeIdade.Verificar(totalPessoas);
                } else if (opcaoMenu == "4")
                {
                    Console.Write("Total de Funcionários para reajustar o salário: ");
                    int totalFuncionarios = Convert.ToInt32(Console.ReadLine());
                    ReajusteSalario.Calcular(totalFuncionarios);
                } else if (opcaoMenu == "5")
                {
                    Console.Write("Total de Alunos: ");
                    int totalAlunos = Convert.ToInt32(Console.ReadLine());
                    Alunos.MaiorEMenor(totalAlunos);
                } else
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
        }
    }
}
