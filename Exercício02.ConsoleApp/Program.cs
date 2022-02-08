using System;

namespace Exercício02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros ímpares entre 100 e 200:");

            for(int i = 0; i < 100; i++)
            {
                int numero = 100 + i;
                int teste = numero % 2;

                if(teste != 0)
                {
                    Console.Write(numero+", ");
                }


            }

            Console.ReadLine();
        }
    }
}
