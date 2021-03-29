using System;
using System.Globalization;
namespace CSharp
{
    class ProgramEight
    {
        public static void Main(string[] args)
        {
            int x, y, z;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z) {
                Console.WriteLine("Menor = " + x);
            }
            else {
                if (y < z) {
                    Console.WriteLine("Menor = " + y);
                }
                else {
                    Console.WriteLine("Menos = " + z);
                }
            }

            Console.ReadLine();
        }
    }
}