using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {   int x = 5;
            int y = 7;
            int z = y - x;

            string s = "Um tab \t e um símbolo de copyright \u00A9";
            string s1 = @"Não é um tab \t e não é um símbolo de copyright \u00A9";
            string s2 = "\u113C \u116E \u113E";
            string s3 = "Oi" + "Tudo bem";
            string s4 = s1 + s2; 
            string s5 = $"{x} mais {y} é igual a {x+y}";
            string s6 = string.Format("Olá {0}, No. {1}", "mundo", 3);
            string s7 = string.Format("Brasil tem {0} mundiais, Portugal tem {1} mundiais", 5, 0);
            
            Console.WriteLine($"{y} menos {x} é igual a {z}");
            Console.WriteLine(s7);
            Console.WriteLine(s6);
            Console.WriteLine(s5);
            Console.WriteLine(s4);
            Console.WriteLine(s3);
            Console.WriteLine(s2);
            Console.WriteLine(s1);
            Console.WriteLine(s);
        }
    }
}
