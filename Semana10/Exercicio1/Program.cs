using System;
using System.IO;
using System.IO.Compression;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
         string caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "input.txt.gz");
        
             
             Comprime(caminho);
        }


    private static void Comprime(string ficheiro)
    {
        string line;

        FileStream fs = new FileStream("ficheiro.txt.gz",FileMode.Create, FileAccess.Write);

        GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

        StreamWriter sw = new StreamWriter(gzs);

        while ((line = Console.ReadLine()).Length > 0)
        {
            sw.WriteLine(line);
        }

        sw.Close();

    }
    }
}
