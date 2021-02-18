using System;
using System.Collections.Generic;

namespace exercicios {

    public class Program {
        public static void Main () {
            int menu = 0;
            do {
                Console.WriteLine ("Digite a opção do programa:");
                Console.WriteLine ("1 - Primo:");
                Console.WriteLine ("2 - Fatorial:");
                Console.WriteLine ("3 - 10 nº array:");
                Console.WriteLine ("4 - Temperatura:");
                Console.WriteLine ("5 - Fila de Banco:");
                Console.WriteLine ("0 - Sair");

                menu = Convert.ToInt32 (Console.ReadLine ());
                switch (menu) {
                    case 0:
                        break;
                    case 1:
                        Primo ();
                        break;
                    case 2:
                        Fatorial ();
                        break;
                    case 3:
                        FuncArray ();
                        break;
                    case 4:
                        Temperatura ();
                        break;
                    case 5:
                        FilaBanco ();
                        break;
                    default:
                        Console.WriteLine ("Opção inválida");
                        break;
                }
            } while (menu != 0);

        }

        public static void Primo () {
            Console.WriteLine ("Digite o valor: ");
            int valor = Convert.ToInt32 (Console.ReadLine ());
            bool primo = true;

            for (int contador = valor - 1; contador > 1; contador--) {
                if ((valor % contador) == 0) {
                    primo = false;
                    break;
                }
            }

            if (primo) {
                Console.WriteLine ("O valor " + valor + " é primo!");
            } else {
                Console.WriteLine ("O valor " + valor + " nao é primo!");
            }
        }

        public static void Fatorial () {
            // 5! = 5 * 4 * 3 * 2 * 1 = 120
            Console.WriteLine ("Digite o valor: ");
            int valor = Convert.ToInt32 (Console.ReadLine ());
            int contador = valor;
            int resultado = 1;

            do {
                resultado *= contador;
                contador--;
            } while (contador > 0);
            Console.WriteLine ("O fatorial de " + valor + " é: " + resultado);
        }

        public static void FuncArray () {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine ("Digite o " + i + " valor:");
                array[i] = Convert.ToInt32 (Console.ReadLine ());
            }

            for (int j = 0; j < array.Length; j++) {
                Console.WriteLine ((array[j] % 2 == 0) ?
                    "Valor na posição " + j + " é par" :
                    "Valor na posição " + j + " é ímpar");
            }
        }

        public static void Temperatura () {
            int[] temperaturas = new int[12];
            int soma = 0;
            for (int i = 0; i < temperaturas.Length; i++) {
                Console.WriteLine ("Digite a temperatura do mês " + (i + 1) + ":");
                temperaturas[i] = Convert.ToInt32 (Console.ReadLine ());
                soma += temperaturas[i];
            }

            Console.WriteLine ("A média de temperaturas do ano foi de " + (soma / 12));

        }

        public static void FilaBanco () {
            int senha = 1;
            Queue<int> fila = new Queue<int> ();
            int opcao = 0;

            do {
                Console.WriteLine ("1 - Retirar senha; 2 - Chamar senha; 3 - Listar fila");
                opcao = Convert.ToInt32 (Console.ReadLine ());
                switch (opcao) {
                    case 0:
                        break;
                    case 1:
                        fila.Enqueue (senha);
                        Console.WriteLine ("A senha retirada é: " + senha);
                        senha++;
                        break;
                    case 2:
                        int chamar = fila.Dequeue ();
                        Console.WriteLine ("A senha a ser chamada é " + chamar);
                        break;
                    case 3:
                        foreach(int valor in fila) {
                            Console.WriteLine(valor);
                        }
                        break;
                    default:
                        Console.WriteLine ("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}