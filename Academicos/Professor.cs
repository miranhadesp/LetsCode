using System;

namespace main{

    public class Professor: Pessoa, IAcademico{ 

    public string Instituicao {get; set;}

    public string Curso {get; set;}

    public char Periodo {get; set;}

        public void Responsabilidade()
        {
            Console.WriteLine("Ensinando os alunos");
        }
    }
}