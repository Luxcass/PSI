using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8; 
            int numero = 7;
            uint numero1 = 14U;
            ulong numero2 = 21UL;
            long numero3 = 28L;

            float jett = 3.144f;
            double reyna = 1.444;
            decimal cypher = 5.233m;
            
            char skye = '\u03DF' ;
            char sova = '\u5351' ;
            bool kayo = true;
            bool omen = false;


            Console.WriteLine(omen);
            Console.WriteLine(kayo);
            Console.WriteLine(sova);
            Console.WriteLine(skye);
            Console.WriteLine(jett);
            Console.WriteLine(reyna);
            Console.WriteLine(cypher);
            Console.WriteLine(numero);
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
                        
        }
    }
}
