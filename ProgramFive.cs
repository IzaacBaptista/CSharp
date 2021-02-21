using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(String[] args) {

            string firstName = Console.ReadLine();
            int  bedromm = int.Parse(Console.ReadLine());
            double product = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InstalledUICulture);

            System.Console.WriteLine("Entre com seu nome completo");
            System.Console.WriteLine(firstName);
            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            System.Console.WriteLine(bedromm);
            System.Console.WriteLine("Entre com o preço de um produto:");
            System.Console.WriteLine(product.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            System.Console.WriteLine(nome);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        } 
    }
}