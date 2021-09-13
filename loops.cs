using System;

namespace prj2{

    class Program{

        static void Main(){

            //int[] ValoresPares = {0, 2, 4, 6}; //matriz unidimensional 
            //int[,] ValoresPeI = {{0, 2, 4, 6}, {1, 3, 5 7}}; //matriz bidimensional
            
            //int[] MatrizUni = new int[6]; //matriz com 6 de tamanho
        }



        static void For(){

            int[] ValoresPares = new int[10];

            int par = 0;

            for(int i = 0; i < 10; i++){    //FORMA 2

                ValoresPares[i] = par;

                par += 2;
            }

            for(int i = 0; i < 10; i++){

                Console.WriteLine(ValoresPares[i]);
            } 
        }



        static void forEachUni(){

            int[] ValoresPares = new int[10];
            
            int i = 0;

            int par = 0;

            Console.WriteLine(ValoresPares.Length);

            while (i < ValoresPares.Length){

                par += 2; 

                ValoresPares[i] = par;

                i++;                   
            }

            foreach (int e in ValoresPares){ //para cada 
                
                Console.WriteLine(e);
            } 
        }


        static void forEachBi(){

            //DESCOBRIR TAMANHO DA MATRIZ BIDIMENSIONAL

            string[,] AlunosLC = new string[25,2];

            Console.WriteLine(AlunosLC.Length); //tamanho total
            Console.WriteLine(AlunosLC.Rank); //número de dimensões
            Console.WriteLine(AlunosLC.GetUpperBound(0)); //mostra a quantidade de elementos -1 em uma dimensão (começa em 0)

            for (int i = 0; i <= AlunosLC.GetUpperBound(0); i++){
                for (int j = 0; j <= AlunosLC.GetUpperBound(1); j++){

                    if (j ==0){

                        Console.Write("\nDigite nome do aluno: ");
                        AlunosLC[i, j] = Console.ReadLine();
                    } 
                    else{

                        Console.Write("Digite a idade do aluno: ");
                        AlunosLC[i, j] = Console.ReadLine();      
                    }
                }
            }

            foreach(string e in AlunosLC){

                Console.WriteLine(e);
            }
        }
    }  
}  

