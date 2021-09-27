using System;


namespace main{

    public interface ILoja{

        string Nome { get; set; }
        int Numeracao{ get; }
        double Aluguel{ get; }
        
        void Vender();
    }
}