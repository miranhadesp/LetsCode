using System;


namespace main{

    public class Poupanca: IInvestimento{

        double valorAplicacao;
        public double ValorAplicacao{

            get{ return valorAplicacao; }
            private set{ valorAplicacao = value; }
        }

        double valorAtual;
        public double ValorAtual{

            get{ return valorAtual; }
            private set{ valorAtual = value; }
        }

        public Poupanca(double valorInicial){

            valorAplicacao = valorInicial;
            valorAtual = valorInicial;
        }

        public void Render(){

            ValorAtual = valorAplicacao * 1.01;
        }
    }
}