using System;

namespace ExemploStaticLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a raiz cúbica de alguns números...");
            Console.WriteLine($"8 => {RaizCubica(8)}");
            Console.WriteLine($"27 => {RaizCubica(27)}");
            Console.WriteLine($"64 => {RaizCubica(64)}");

            static double RaizCubica(double valor) =>
                Math.Round(Math.Pow(valor, 1.0 / 3.0), 2);
        }
    }
}