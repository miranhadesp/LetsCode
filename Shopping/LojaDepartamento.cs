using System;

namespace main{

    public class LojaDepartamento : IVestuario{
        
        private string nome;
        public string Nome{

            get{ return nome; }
            set{ nome = value; }
        }

        public int Numeracao{

            get{ return 101; }
        }

        public double Aluguel{

            get{ return 10000; }
        }

        public LojaDepartamento(string nome){

            Nome = nome;
        }

        public void Vender(){

            ProcurarNoEstoque();
            Console.WriteLine($"{Nome} - Venda concluída com sucesso");
        }

        public void ProcurarNoEstoque(){

            Console.WriteLine("Subir escada correndo");
            Console.WriteLine("Bater o pé no teto");
            Console.WriteLine("Descer correndo"); 
        }
    }
}