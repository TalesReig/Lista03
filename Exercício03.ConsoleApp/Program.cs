using System;

namespace Exercício03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de todos os números ímpares que são múltiplos de três " +
            "e que se encontram no conjunto dos números de 1 até 500.");
            int acumulador = 0 ;
            for (int i = 0; i < 500; i++)
            {
                int numero = 0 + i;
                int teste = numero % 2;
                int teste2 = numero % 3;

                if (teste != 0 && teste2 == 0 )
                {
                    acumulador = numero + acumulador;
                }
            }
            Console.Write("A soma destes números é: "+acumulador);
        }
    }
}
