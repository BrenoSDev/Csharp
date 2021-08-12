using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutrosMetodos
{
    public static class AcoesExtras
    {
        public static void ExibirNome()
        {
            Console.WriteLine("Digite seu nome na linha abaixo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer, {0}!", nome);
            Console.WriteLine(string.Format("Olá, meu nome é {0}", nome));
        }

        public static void VerificadorDeIdade()
        {
            int idade;
            Console.Write("Digite sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);
            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão Concedida!");
            }
        }

        public static void TrocarALetraA()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            char[] arrayDeCaracteres = frase.ToCharArray(); //Cria uma matriz dos caracteres da frase
            int posicao = 0;
            foreach (char letra in arrayDeCaracteres)
            {
                if (letra == 'a' || letra == 'A')
                {
                    arrayDeCaracteres[posicao] = '&';
                }
                posicao++;
            }
            string novaFrase = new string(arrayDeCaracteres);
            Console.WriteLine(novaFrase);
        }

        public static void GravarInformacoesTxt(string arq, string[] dados)
        {
            string dadosIniciais = MostrarInformacoesTxt(arq);
            using (Stream arquivo = File.Open(arq, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(arquivo))
            {
                escritor.WriteLine(dadosIniciais);
                foreach (string informacao in dados)
                {
                    escritor.WriteLine(informacao);
                }
            }
        }
        public static string MostrarInformacoesTxt(string arq)
        {
            using (Stream arquivo = File.Open(arq, FileMode.Open))
            using (StreamReader leitor = new StreamReader(arquivo))
            {
                return leitor.ReadToEnd();
            }
        }
    }
}
