using System;

namespace Escrever03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Insere um número inteiro: ");
                try{
                      i = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
{
    // Código para tratar exceção
    Console.WriteLine("Ocorreu o seguinte problema: " + e.Message);
}

            Console.WriteLine($"Número inserido: {i}");

        }
    }
}
