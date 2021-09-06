using System;

namespace prj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int x; 
            //float z;  
            //double a;
            //string y;
            //char c; 
            //bool b = true;

            const string MensagemBoasVindas = "Hello Word";

            Console.WriteLine(MensagemBoasVindas);
            Console.WriteLine("Escolha uma das opções abaixo:\n");

            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");
            Console.WriteLine("5 - módulo");
            Console.WriteLine("6 - sair");

            int opcao;
            Console.Write("\nEscolha sua opção: ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            if(opcao == 6) Environment.Exit(0);

            double x;
            Console.Write("Digite o primeiro valor: ");
            Double.TryParse(Console.ReadLine(), out x);

            double y;
            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out y); //verifica se conseguiu converter para double com 'bool krl ='

            switch (opcao)
            {
                case 1:

                    Console.WriteLine($"\nA soma dos dois valores é: {x + y}");
                break;

                case 2:

                    Console.WriteLine($"A subtração dos dois valores é: {x - y}");
                break;

                case 3:

                    Console.WriteLine($"A subtração dos dois valores é: {x - y}");
                break;

                case 4:

                    Console.WriteLine($"A divisão dos dois valores é: {x / y}");
                break;

                case 5:

                    Console.WriteLine($"O resto da divisão dos dois valores é: {x % y}\n");
                break;

                default:
            }

            /*
            if(opcao == 6){

                Environment.Exit(0); // sai do programa
            }

            else if(opcao < 1 || opcao > 6){ //AND = E -> && //OR = OU -> || // NOT = NÃO = !

                Console.WriteLine("\nOpção incorreta, tente novamente mais tarde");
                Environment.Exit(0); // sai do programa
            }

            if(opcao == 1){

                Console.WriteLine($"\nA soma dos dois valores é: {x + y}");
            }

            else if(opcao == 2){

                Console.WriteLine($"A subtração dos dois valores é: {x - y}");
            }
            
            else if(opcao == 3){

                Console.WriteLine($"A multiplicação dos dois valores é: {x * y}");
            }

            else if(opcao == 4){

                Console.WriteLine($"A divisão dos dois valores é: {x / y}");
            }
            
            else if(opcao == 5){

                Console.WriteLine($"O resto da divisão dos dois valores é: {x % y}\n");
            } */

            

            //necessidade de converter ReadLine() pois o mesmo está em string por padrão

            //Console.Write("\nOpção: ");
            //int opcao = Convert.ToInt32(Console.ReadLine(); só o int precisa dessa alocação de bit (16, 32, 64)

        }
    }
}