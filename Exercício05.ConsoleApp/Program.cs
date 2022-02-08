using System;

namespace Exercício05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer saber o fatorial de qual numero ?");
            int num = Convert.ToInt32(Console.ReadLine());
            int resultado=1;
            for (int i = 0; i < num; i++)
            {
                resultado = (num - i ) * resultado;
            }

            Console.WriteLine("O fatorial de "+num+" é: "+resultado);
        }
    }
}
