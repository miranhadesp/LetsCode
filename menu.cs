using System;

namespace main{

    class Menu{ //classe

        static public void MenuCalc(){ //método

            Console.WriteLine("Escolha uma das opções abaixo:\n");

            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");
            Console.WriteLine("5 - módulo");
            Console.WriteLine("6 - sair");

            Console.Write("\nOpção: ");
            Opcao.OpcaoSelecionada(Convert.ToInt32(Console.ReadLine()));
        } 
    }
}