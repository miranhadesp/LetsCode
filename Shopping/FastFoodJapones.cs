using System;

namespace main{

    public class FastFoodJapones : FastFood, IAlimentacao{
        
        public FastFoodJapones(string nome) : base(nome){  }

        public override void PrepararPedido(){

            Console.WriteLine("Espalhando Arroz");
            Console.WriteLine("Enrolando sushi");
            Console.WriteLine("Cortando alga");
        }
    }
}