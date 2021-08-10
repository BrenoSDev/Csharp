using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIOSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensagem que vai para o terminal");
            //Quando queremos ler uma linha que o usuário digitou no terminal, utilizamos um atributo do tipo
            //TextReader da classe Console chamado In:
            TextReader leitor = Console.In;
            //No TextReader, temos o método ReadLine que consegue ler uma linha no terminal
            string linha = leitor.ReadLine();
            Console.WriteLine(linha);
            //O ReadLine devolve uma string não nula, enquanto o usuário continuar enviando novas linhas.
            while (linha != null)
            {
                linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
            //Quando o usuário manda a combinação Crtl + Z para a aplicação, o leitor devolve null.
        }
    }
}
