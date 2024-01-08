using System;
using System.IO;

namespace Escrever02
{
    class Program
    {
        private static string caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "input.txt");

        static void Main(string[] ars)
        {
            string input;

            StreamWriter escrever = new StreamWriter(caminho);

            Console.Write("Escreve várias linhas de texto para guardar num ficheiro");
            Console.Write("\nPressiona a tecla ENTER quando quiseres terminar\n");

            do
            {
                input = Console.ReadLine();

                if(input != "")
                sw.WriteLine(input);

            }
            while (input != "");
    
            sw.Close(); 
        }
    }
}
