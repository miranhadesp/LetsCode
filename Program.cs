using System;

namespace main{

    class Program{

        static void Main(string[] args){

            Menu menu = new Menu();
        
            Console.WriteLine("Bem vindo ao código da turma Sinqia C#");
            //menu.MenuGeral(); 

            Generics generics = new Generics();

            var lojas = new List<ILoja>;
            var mcdonalds = new FastFood("MCDUNALD", 100000);

            lojas.Add(mcdonalds);
            lojas.Add(new FastFood("BK", 100000));
            lojas.Add(new FastFood("Girafas", 100000));
            lojas.Add(new FastFood("XPicanha", 100000));

            genercis.Load();
            generics.Save(lojas);
            genercis.Load();

            mcdonalds.Nome = "McDonalds";
            genercis.Save(mcdonalds);
            genercis.Load();
        }
    }
}