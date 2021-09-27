using System;

namespace main{

    class Menu{ //classe

        public void MenuCalc(){ //método

            Calculadora calc = new Calculadora();

            Console.WriteLine("Escolha uma das opções abaixo:\n");

            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");
            Console.WriteLine("5 - módulo");
            Console.WriteLine("6 - fatorial");
            Console.WriteLine("0 - sair da calculadora e voltar ao menu");

            Console.Write("\nOpção: ");
            calc.OpcaoSelecionada(Convert.ToInt32(Console.ReadLine()));
        }

        public void MenuGeral(){

            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - calculadora");
            Console.WriteLine("2 - Cadastrar pessoa");
            Console.WriteLine("3 - Visualizar dados da pessoa cadastrada");
            Console.WriteLine("4 - Sistema Shopping");
            Console.WriteLine("0 - sair do código");
            Console.Write("\nOpção: ");


            switch (Convert.ToInt32(Console.ReadLine())){

                case 1:

                    MenuCalc();
                break;

                case 2:

                case 3:

                case 4:

                    MenuShopping(new List<ILoja>());
                    break;

                case 0:

                    Environment.Exit(0);

                break;

                default:

                    Console.WriteLine("Opção Inválida!");
                    MenuGeral();
                break;
            }
        } 

        public void MenuShopping(List<ILoja> lojas){

            Polimorfismo menuShopping = new Polimorfismo(lojas);

            Console.WriteLine("\nBem vindo ao Menu do Shopping");
            Console.WriteLine("1 - Listas Lojas Cadastradas");
            Console.WriteLine("2 - Realizar Compra");
            Console.WriteLine("3 - Cadastrar Loja Departamento");
            Console.WriteLine("4 - Cadastrar Fast Food");
            Console.WriteLine("5 - Remover Loja ou Fast Food");
            Console.WriteLine("0 - Sair do menu shopping e voltar ao menu inicial");
            Console.Write("Opção: ");
            menuShopping.SelectOption(Convert.ToInt32(Console.ReadLine()));
        }
    }
}