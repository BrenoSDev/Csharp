using System;

namespace TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 1;

            var x = 1;

            string s = "Breno";
            var s2 = "Breno2";

            var f = 1.5;
            float f2 = 1.5f;
            var d = 3.5;
            double d2 = 4.5;
            char t = 'a';


            var bo = true;
            bool bo2 = false;

            bool boolean = bool.Parse('false');
            bool boolean2 = Convert.ToBoolean("false");

            animal a = new animal();
            Leao L = new Leao();

            a = L;

            d.ToString();

            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(t);
            Console.Write(bo);
            Console.Write(bo2);
        }
    }

    public class animal
    {

    }
    public class Leao : animal { 
    
    }
}
