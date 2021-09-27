using System;

namespace main{

    public interface IInvestimento{
        
        double ValorAplicacao{ get; }

        double ValorAtual{ get; }

        void Render();
    }
}