using System;
using System.Collections.Generic;

namespace exercicios {

    public class ContaCorrente {
        private string NumeroConta;
        private string Agencia;
        private Titular Titular;
        private Gerente Gerente;
        private double Saldo;

        public ContaCorrente(string NumeroConta, string Agencia, Titular Titular, Gerente Gerente) {
            this.SetNumeroConta(NumeroConta);
            this.SetAgencia(Agencia);
            this.SetTitular(Titular);
            this.SetGerente(Gerente);
            this.SetSaldo(0);
        }

        public void SetNumeroConta(string NumeroConta) {
            this.NumeroConta = NumeroConta;
        }
        public void SetAgencia(string Agencia) {
            this.Agencia = Agencia;
        }
        public void SetTitular(Titular Titular) {
            this.Titular = Titular;
        }
        public void SetGerente(Gerente Gerente) {
            this.Gerente = Gerente;
        }
        public void SetSaldo(double Saldo) {
            this.Saldo = Saldo;
        }

        public string GetNumeroConta() {
            return this.NumeroConta;
        }
        public string GetAgencia() {
            return this.Agencia;
        }
        public Titular GetTitular() {
            return this.Titular;
        }

        public Gerente GetGerente() {
            return this.Gerente;
        }
        public double GetSaldo() {
            return this.Saldo;
        }

        public void Deposito(double valor) {
            this.SetSaldo(this.GetSaldo() + valor);
        }
        
        public void Saque(double valor) {
            this.SetSaldo(this.GetSaldo() - valor);
        }

        public override string ToString () {
            return $"Informações do Titular: \n{this.GetTitular()}\n" + 
                $"Informações do Gerente: \n{this.GetGerente()}\n" + 
                $"Agência: {this.GetAgencia()}\n" + 
                $"Conta Corrente: {this.GetNumeroConta()}\n" +
                $"Saldo:{this.GetSaldo()}";
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            ContaCorrente contaCorrente = (ContaCorrente) obj;
            return this.GetNumeroConta () == contaCorrente.GetNumeroConta () 
                && this.GetAgencia() == contaCorrente.GetAgencia();
        }
    }
    public class Pessoa {
        private string Nome;
        private double Peso;
        private double Altura;
        private string DataNascimento;

        protected Pessoa (string Nome, double Peso, double Altura, string DataNascimento) {
            this.SetNome(Nome);
            this.SetPeso(Peso);
            this.SetAltura(Altura);
            this.SetDataNascimento(DataNascimento);
        }

        public void SetNome (string Nome) {
            this.Nome = Nome;
        }
        public void SetPeso (double Peso) {
            this.Peso = Peso;
        }
        public void SetAltura (double Altura) {
            this.Altura = Altura;
        }
        public void SetDataNascimento (string DataNascimento) {
            this.DataNascimento = DataNascimento;
        }

        public string GetNome () {
            return this.Nome;
        }
        public double GetPeso () {
            return this.Peso;
        }
        public double GetAltura () {
            return this.Altura;
        }
        public string GetDataNascimento () {
            return this.DataNascimento;
        }

        public override string ToString () {
            return $"Nome: {this.GetNome()}\nIMC: {this.GetIMC()}\nPeso: {this.GetPeso()}\nAltura:{this.GetAltura()}";
        }

        public double IMC() {
            return Peso/(Altura*Altura);
        }

        public string GetIMC() {
            double imc = this.IMC();

            if (imc < 18.5) {
                return "Abaixo do Peso";
            } else if (imc < 25.0) {
                return "Peso Ideal";
            } else if (imc < 30.0) {
                return "Levemente acima do peso";
            } else if (imc < 35.0) {
                return "Obesidade Grau I";
            } else if (imc < 40) {
                return "Obesidade Grau II";
            }

            return "Obesidade Grau III (mórbida)";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            Pessoa pessoa = (Pessoa) obj;
            return this.GetNome () == pessoa.GetNome ();
        }
    }

    public class Titular : Pessoa {
        private string Cpf;
        public Titular(string Nome, double Peso, double Altura, string DataNascimento, string Cpf) 
            : base(Nome, Peso, Altura, DataNascimento) {
            this.SetCpf(Cpf);
        }

        public void SetCpf(string Cpf) {
            this.Cpf = Cpf;
        }

        public string GetCpf() {
            return this.Cpf;
        }
    }

    public class Gerente : Pessoa {
        private string Matricula;
        public Gerente(string Nome, double Peso, double Altura, string DataNascimento, string Matricula) 
            : base(Nome, Peso, Altura, DataNascimento) {
            this.SetMatricula(Matricula);
        }

        public void SetMatricula(string Matricula) {
            this.Matricula = Matricula;
        }

        public string GetMatricula() {
            return this.Matricula;
        }

        public override string ToString () {
            return $"Nome: {this.GetNome()}\n" + 
                $"Matrícula: {this.GetMatricula()}";
        }
    }

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
                Console.WriteLine ("6 - Cadastrar Pessoa");
                Console.WriteLine ("7 - Conta Corrente");
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
                    case 6:
                        CadastrarPessoa();
                        break;
                    case 7:
                        Banco();
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
                        foreach (int valor in fila) {
                            Console.WriteLine (valor);
                        }
                        break;
                    default:
                        Console.WriteLine ("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }

        public static void CadastrarPessoa() {
            Console.WriteLine("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a altura da pessoa: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso da pessoa: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a data de nascimento da pessoa: ");
            string dataNascimento = Console.ReadLine();
            Titular pessoaA = new Titular(nome, peso, altura, dataNascimento, "");
            
            Console.WriteLine("Digite o nome da pessoa: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a altura da pessoa: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso da pessoa: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a data de nascimento da pessoa: ");
            dataNascimento = Console.ReadLine();
            Titular pessoaB = new Titular(nome, peso, altura, dataNascimento, "");

            Console.WriteLine(pessoaA);
            Console.WriteLine(pessoaB);
            Console.WriteLine("As pessoas são: ");
            Console.WriteLine(pessoaA.Equals(pessoaB) ? "Igual" : "Diferente");
            Console.WriteLine(pessoaA == pessoaB ? "Igual" : "Diferente");
        }

        public static void Banco() {
            Console.WriteLine("Digite o nome do titular: ");
            string nomeTitular = Console.ReadLine();
            Titular titular = new Titular(nomeTitular,0,0,"","");
            Console.WriteLine("Digite o nome do gerente: ");
            string nomeGerente = Console.ReadLine();
            Gerente gerente = new Gerente(nomeGerente,0,0,"","");
            Console.WriteLine("Digite o número da conta: ");
            string numeroConta = Console.ReadLine();
            Console.WriteLine("Digite a agência: ");
            string agencia = Console.ReadLine();

            ContaCorrente conta = new ContaCorrente(numeroConta, agencia, titular, gerente);
            int repeticao = 0;
            do {
                Console.WriteLine("Digite a operação: (0-Sair, 1-Depósito, 2-Saque, 3-Saldo) ");
                int operacao = Convert.ToInt32(Console.ReadLine());
                switch(operacao) {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Digite o valor para depósito: ");
                        conta.Deposito(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor para sacar: ");
                        conta.Saque(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine(conta);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("Deseja realizar outra operação? (1 - Sim)");
                repeticao = Convert.ToInt32(Console.ReadLine());
            } while (repeticao == 1);
        }
    }