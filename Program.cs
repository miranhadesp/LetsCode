using System;

namespace prj1{

    class Program{

        static void Main(string[] args){

            const string MensagemBoasVindas = "Hello Word";
            const string MensagemSistema = "Bem vindo a calculadora";

            Console.WriteLine(MensagemBoasVindas);
            //Console.WriteLine(MensagemSistema);
         
            //Menu(); -> pause na calculadora

            EstruturaFor();
            EstruturaWhile();
            EstruturaDoWhile();
            Random();

            }

        static double LerValor1(){

            double x;
            Console.Write("Digite o primeiro valor: ");
            Double.TryParse(Console.ReadLine(), out x);

            return x;
        }

        static double LerValor2(){

            double y;
            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out y);

            return y;
        }

        static void Menu(){

            Console.WriteLine("Escolha uma das opções abaixo:\n");

            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");
            Console.WriteLine("5 - módulo");
            Console.WriteLine("6 - sair");

            Console.Write("\nOpção: ");
            OpcaoSelecionada(Convert.ToInt32(Console.ReadLine()));
        }

        static void OpcaoSelecionada(int opcao){

            switch (opcao)
            {
                case 1:

                    Console.WriteLine($"\nA soma dos dois valores é: {LerValor1() + LerValor2()}\n");
                    Menu();
                break;

                case 2:

                    Console.WriteLine($"A subtração dos dois valores é: {LerValor1() - LerValor2()}\n");
                    Menu();
                break;

                case 3:

                    Console.WriteLine($"A multiplicação dos dois valores é: {LerValor1() * LerValor2()}\n");
                    Menu();
                break;

                case 4:

                    Console.WriteLine($"A divisão dos dois valores é: {LerValor1() / LerValor2()}\n");
                    Menu();
                break;

                case 5:

                    Console.WriteLine($"O resto da divisão dos dois valores é: {LerValor1() % LerValor2()}\n");
                    Menu();
                break;

                case 6:

                    Environment.Exit(0);
                break;

                default:

                    Console.WriteLine("Opção inválida!");
                    Menu();
                break;
            }
        }

        static void EstruturaFor(){

            Console.Write("Digite um valor para ser calculado seu fatorial: ");
           
            int fatorial;
            Int32.TryParse(Console.ReadLine(), out fatorial);

            int res = fatorial;
            
            //loop numérico
            for(int i = (fatorial-1); i >= 1; i--){
                
                res = res * i;
            }

            Console.WriteLine($"O resultado em For é: {res}\n");
        }

        static void EstruturaWhile(){

            Console.Write("Digite um valor para ser calculado seu fatorial: ");
            
            int fatorial, i, res;
            Int32.TryParse(Console.ReadLine(), out fatorial);

            i = fatorial - 1;
            res = fatorial;

            while(i > 0){

                res = res * i;

                i--;
            }

            Console.WriteLine($"O resultado em While é: {res}\n");
        }

        static void EstruturaDoWhile(){

            int num;

            do{

            Console.Write("Adivinhe o número entre 1 e 5: ");

            Int32.TryParse(Console.ReadLine(), out num);
                
            } while (num != 3);
        }

        static void Random(){

            Random random = new Random(); //instanciando a função

            int z = random.Next(5); // n inteiro não negativo até 5

            Console.Write($"Número aleatório: {z}");

            int k = random.Next(1,5); //número inteiro não negativo de 1 até 5

            Console.Write($"Número aleatório: {k}");
        }
    }
}