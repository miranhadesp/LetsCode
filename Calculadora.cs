using System;

namespace main{

    class Calculadora{

        private double result;

        private double numberOne;
        private double numberTwo;

        public double Result{
            
            get{ return result; }              //get -> Retornar o valor da variável para o usuário ou método
            private set { result = value; }    //set -> Salvar o valor na variável
        }

        private void Fatorial(){

            Result = numberOne;

            for(int i = ((int) numberOne - 1); i >= 1; i--){

                Result *= i;
            }
        }

        private void Sum(){

            Result = NumberOne + NumberTwo;
        }

        private void Subtract(){

            Result = NumberOne - NumberTwo;
        }

        private void Mult(){

            Result = NumberOne * NumberTwo;
        }

        private void Div(){

            Result = NumberOne / NumberTwo;
        }

        private void Mod(){

            Result = NumberOne % NumberTwo;
        }


        public double NumberOne{

            get { return numberOne; } 
        }

        public double NumberTwo{

            get { return numberTwo; }
        }

        public void SetNumberOne(bool fatorial = false){ //atribuir valor

            if(!fatorial) Console.Write("Digite o primeiro valor: ");
            
            else Console.Write("Digite o valor para ser calculado o fatorial: ");
            
            Double.TryParse(Console.ReadLine(), out numberOne);
        }

        public void SetNumberTwo(){

            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out numberTwo);
        }

        public void OpcaoSelecionada(int opcao){

            Menu menu = new Menu();

            switch (opcao){

                case 0:

                    menu.MenuGeral();
                break;

                case 1:

                    SetNumberOne();
                    SetNumberTwo();
                    Sum();
                    Console.WriteLine($"\nA soma dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                    //classe.método
                break;

                case 2:

                    SetNumberOne();
                    SetNumberTwo();
                    Subtract();
                    Console.WriteLine($"A subtração dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                break;

                case 3:

                    SetNumberOne();
                    SetNumberTwo();
                    Mult();
                    Console.WriteLine($"A multiplicação dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                break;

                case 4:

                    SetNumberOne();
                    SetNumberTwo();
                    Div();
                    Console.WriteLine($"A divisão dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                break;

                case 5:
                    
                    SetNumberOne();
                    SetNumberTwo();
                    Mod();
                    Console.WriteLine($"O resto da divisão dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                break;

                case 6:
                    
                    SetNumberOne();
                    SetNumberTwo();
                    Fatorial();
                    Console.WriteLine($"O fatorial do número informado é: {Result}\n");
                    menu.MenuCalc();
                break;

                default:

                    Console.WriteLine("Opção inválida!");
                    menu.MenuCalc();
                break;
            }
        }
    }
}