/*Estrutura condicional*/
using System;
namespace CSharp
{
    class ProgramTwo
    {
        public static void Main(string[] args)
        {
            int horas;

            System.Console.WriteLine("Quantas horas");
            horas = int.Parse(Console.ReadLine());

            if(horas < 12) {
                Console.WriteLine("Bom dia!");   
            }   
            else if(horas < 18) {
                Console.WriteLine("Boa tarde!");   
            }
            else {
                Console.WriteLine("Boa noite!");   
            }
            Console.ReadLine();
        }
    }
}