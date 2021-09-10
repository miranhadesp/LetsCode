using System;

namespace main{

    class Program{

        static void Main(string[] args){

            const string MensagemBoasVindas = "Hello Word";
            const string MensagemSistema = "Bem vindo a calculadora";

            Console.WriteLine(MensagemBoasVindas);
            //Console.WriteLine(MensagemSistema);
         
            Menu.MenuCalc(); 
        }

        static public double LerValor1(){

            double x;
            Console.Write("Digite o primeiro valor: ");
            Double.TryParse(Console.ReadLine(), out x);

            return x;
        }

        static public double LerValor2(){

            double y;
            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out y);

            return y;
        }
    }
}