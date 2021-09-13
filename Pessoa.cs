using System;

namespace prj2{

    class Pessoa{

        string nome;

        double altura;
        double peso;

        int calcado;

        int diaNascimento;
        int mesNascimento;
        int anoNascimento;

        public int idade(){

            return DateTime.Now.Year - anoNascimento;
        }

        public void novoPeso(int qtdPerdeu){

            peso -= qtdPerdeu;
        }


        
    } 
}  
