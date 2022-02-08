using System;

namespace Exercício01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MaiorAltura = 0, MenorAltura = 1000,Altura;

            for (int i = 0; i < 3; i++){
                Console.Write("Digite a altura ( em metros ) da pessoa da posição " + i + ": ");
                Altura = Convert.ToDouble(Console.ReadLine());

                if (Altura > MaiorAltura) {
                    MaiorAltura = Altura;
                }
                if (Altura < MenorAltura)
                {
                    MenorAltura = Altura;
                }
            }

            Console.WriteLine("\n A maior altura é " + MaiorAltura + "m e a menor altura é " + MenorAltura + "m.");
            Console.ReadLine();
        }
    }
}
