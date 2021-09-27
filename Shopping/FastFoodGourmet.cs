using System;

namespace main{ 

    public class FastFoodGourmet: FastFood, IAlimentacao{

        public FastFoodGourmet(string nome) : base(nome){ }

        public override void PrepararPedido(){

            base.PrepararPedido();
            Console.WriteLine("Renomeando batatas fritas, para batatas rústicas");
            Console.WriteLine("Adicionando palavra orgânico ao lanche");
            Console.WriteLine("Pedido embalado em sacolas de papel reciclavel");
        }
    }
}