using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForsEncadeadosEX
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int linha = 1; linha <= 10; linha++)
            {
                int valor = linha;
                for (int c = 1; c<=linha; c++ )
                {
                    Console.Write(valor + " ");
                    valor += linha;
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
