using System;
using System.IO;

namespace Escrever01
{
    class Program
    {
        private static string caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "input.txt");

        static void Main(string[] ars)
        {
            string input;

            string[] linhas = new string[10];

            int i = 0;

            do
            {
                input = " ";
                input = Console.ReadLine();

                if(input != "")
                linhas[i] = input;
                i++;
            }
            while (input != "");
    
            File.WriteAllLines(caminho, linhas);
        }
    }
}
