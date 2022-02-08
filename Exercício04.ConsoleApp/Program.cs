using System;

namespace Exercício04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer saber a tabuade de qual numero ?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine(num+" * "+i+" = "+resultado);
            }
        }
    }
}
