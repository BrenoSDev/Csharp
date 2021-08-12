using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosMatematicos;
using OutrosMetodos;

namespace ConsoleMatematicoEX
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.ForegroundColor = ConsoleColor.Blue; //Altera a cor da fonte
                Console.WriteLine("\nSeja bem vindo ao Sistema Breno.Console!\n");
                Console.WriteLine("\nMenu:" +
                    "\n0 - Sair do Programa\n" +
                    "1 - Par ou Ímpar\n" +
                    "2 - Mostrar nome na tela\n" +
                    "3 - Calculadora\n" +
                    "4 - Verificador de Idade\n" +
                    "5 - Trocar a letra Aa por & em uma frase\n" +
                    "6 - Reajuste de Salário\n" +
                    "7 - Cadastro de Cliente\n" +
                    "8 - Cálculo IMC\n");
                Console.Write("Opção escolhida: ");
                string opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    break;
                }  else if (opcao == "1")
                {
                    Console.Write("Digite um valor: ");
                    string v = Console.ReadLine();
                    try
                    {
                        int valor = Convert.ToInt32(v);
                        string resultado = Formulas.ParOuImpar(valor);
                        Console.WriteLine("O valor digitado é {0}", resultado);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor Incorreto! Digite um valor inteiro!");
                    }
                } else if (opcao == "2")
                {
                    AcoesExtras.ExibirNome();
                } else if (opcao == "3")
                {
                    Formulas.Calculadora();
                } else if (opcao == "4")
                {
                    AcoesExtras.VerificadorDeIdade();
                } else if (opcao == "5")
                {
                    AcoesExtras.TrocarALetraA();
                } else if (opcao == "6")
                {
                    Console.Write("Digite seu salário atual: ");
                    double salario;
                    double.TryParse(Console.ReadLine(), out salario);
                    double novoSalario = Formulas.ReajusteSalario(salario);
                    Console.WriteLine("Seu novo salário é de {0}", novoSalario);
                } else if (opcao == "7")
                {
                    Console.WriteLine("O que você deseja fazer:\n" +
                        "G - gravar informações\n" +
                        "L - ler informações\n");
                    Console.Write("Ação: ");
                    string acao = Console.ReadLine();
                    if (acao == "G")
                    {
                        string nome, email, telefone, rg;
                        Console.WriteLine("Cadastro de Usuário");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("E-mail: ");
                        email = Console.ReadLine();
                        Console.Write("Telefone: ");
                        telefone = Console.ReadLine();
                        Console.Write("Rg: ");
                        rg = Console.ReadLine();
                        string arquivo = "dados.txt";
                        string[] dados = new string[4];
                        dados[0] = nome;
                        dados[1] = email;
                        dados[2] = telefone;
                        dados[3] = rg;
                        AcoesExtras.GravarInformacoesTxt(arquivo, dados);
                    } else if (acao == "L")
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Informações do Arquivo dados.txt");
                        Console.WriteLine("------------------------------------------------------------------");
                        string dados = AcoesExtras.MostrarInformacoesTxt("dados.txt");
                        Console.WriteLine(dados);
                    } else
                    {
                        Console.WriteLine("Ação Inexistente!");
                    }
                } else if (opcao == "8")
                {
                    Console.WriteLine("0 que você deseja fazer:\n" +
                        "N - novo cadastro\n" +
                        "C - consultar cadastros existentes\n");
                    Console.Write("Ação: ");
                    string acao = Console.ReadLine();
                    if (acao == "N")
                    {
                        string[] dados = new string[3];
                        Console.Write("Nome: ");
                        string nome = "Nome: " + Console.ReadLine();
                        Console.Write("Idade: ");
                        string idade = "Idade: " + Console.ReadLine();
                        Console.Write("Peso(Kg): ");
                        double peso, altura;
                        double.TryParse(Console.ReadLine(), out peso);
                        Console.Write("Altura(metros): ");
                        double.TryParse(Console.ReadLine(), out altura);
                        double imc = Formulas.CalculoImc(peso, altura);
                        dados[0] = nome;
                        dados[1] = idade;
                        dados[2] = Convert.ToString(imc);
                        AcoesExtras.GravarInformacoesTxt("dadosImc.txt", dados);
                    }
                    else if (acao == "C")
                    {
                        string dados = AcoesExtras.MostrarInformacoesTxt("dadosImc.txt");
                        Console.WriteLine(dados);
                    }
                    else
                    {
                        Console.WriteLine("Ação Inválida!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Incorreta!");
                }
            }
        }
    }
}
