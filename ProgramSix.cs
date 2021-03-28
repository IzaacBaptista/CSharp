/*using System;
using System.Globalization;

namespace Course {
    class ProgramSix {
        static void Main(String[] args) {

            //converter string para int
            int n1 = int.Parse(Console.ReadLine());

            //converter string para char
            char ch = char.Parse(Console.ReadLine());

            //converter string para double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InstalledUICulture);

            System.Console.WriteLine("Você Digitou");
            System.Console.WriteLine(n1);
            System.Console.WriteLine(ch);
            System.Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(nome);
            System.Console.WriteLine(sexo);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        } 
    }
}*/