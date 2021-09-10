using System;

namespace main{

    class Opcao{

        static public void OpcaoSelecionada(int opcao){

            switch (opcao){

                case 1:

                    Console.WriteLine($"\nA soma dos dois valores é: {Program.LerValor1() + Program.LerValor2()}\n");
                    Menu.MenuCalc();
                    //classe.método
                break;

                case 2:

                    Console.WriteLine($"A subtração dos dois valores é: {Program.LerValor1() - Program.LerValor2()}\n");
                    Menu.MenuCalc();
                break;

                case 3:

                    Console.WriteLine($"A multiplicação dos dois valores é: {Program.LerValor1() * Program.LerValor2()}\n");
                    Menu.MenuCalc();
                break;

                case 4:

                    Console.WriteLine($"A divisão dos dois valores é: {Program.LerValor1() / Program.LerValor2()}\n");
                    Menu.MenuCalc();
                break;

                case 5:

                    Console.WriteLine($"O resto da divisão dos dois valores é: {Program.LerValor1() % Program.LerValor2()}\n");
                    Menu.MenuCalc();
                break;

                case 6:

                    Environment.Exit(0);
                break;

                default:

                    Console.WriteLine("Opção inválida!");
                    Menu.MenuCalc();
                break;
            }
        }
    }
}