using System;

namespace main{

    public class CDB : IInvestimento{ 

        double valorAplicacao;
        public double ValorAplicacao{

            get{ return 60; }
            private set{ valorAplicacao = value; }
        }

        double valorAtual;
        public double ValorAtual{

            get{ return valorAtual; }
            private set{ valorAtual = value; }
        }

        public CDB(double valorInicial){

            valorAplicacao = valorInicial;
            valorAtual = valorInicial;
        }

        public void Render(){

            ValorAtual = ValorAplicacao * 1.10;
        }
    }
}
