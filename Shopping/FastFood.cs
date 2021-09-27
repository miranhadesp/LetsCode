using System;

namespace main{

    public class FastFood: IAlimentacao{

        private string nome;
        public string Nome{

            get{ return nome; }
            set{ nome = value; }
        }

        public int Numeracao{

            get{ return 101; }
        }

        double aluguel = 100000;
        public double Aluguel{

            get{ return aluguel; }
        }

        public FastFood(string nome){

            Nome = nome;
        }

        public FastFood(string nome, double aluguel){

            Nome = nome;
            this.aluguel = aluguel;
        }

        public void Vender(){

            PrepararPedido();
            Console.WriteLine($"{Nome} - Venda concluída com sucesso!");
        }

        public virtual void PrepararPedido(){

            Console.WriteLine("Hamburguer na chapa");
            Console.WriteLine("Refrigerante no copo");
            Console.WriteLine("Batatas fritando");
        }
    }
}