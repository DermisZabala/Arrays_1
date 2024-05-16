using System;

namespace Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5] {"Pedro", "Juan", "Maria", "Teresa", "Hamel"};
            int[] edades = new int[5];
            edades[0] = 19;
            edades[1] = 30;
            edades[2] = 24;
            edades[3] = 50;
            edades[4] = 91;

            Console.WriteLine($"Nombres \tEdades\n{nombres[0]} \t\t{edades[0]}\n{nombres[1]} \t\t{edades[1]}\n" +
                $"{nombres[2]} \t\t{edades[2]}\n{nombres[3]} \t\t{edades[3]}\n" +
                $"{nombres[4]} \t\t{edades[4]}\n");

            Console.ReadKey();
        }
    }
}
