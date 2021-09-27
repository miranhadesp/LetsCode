using System;

namespace main{

    public class Generics{

        Repositorio<ILoja> repositorio = new Repositorio<ILoja>();

        public int GetId(ILoja loja){

            //var id =

            return 23;
        }

        public void Load(){

            Console.WriteLine("Exibindo lojas do repositorio: ");

            foreach (var e in repositorio.GetItems().Values.ToList()){

                Console.WriteLine(loja.Nome);
            }
        }

        public void Save(List<ILoja> lojas){

            int id = 0;

            foreach (var e in lojas){

                this.repositorio.AdicionarOuAtualizar(id, loja);
            }
        }

        public void Save(ILoja loja){

            var id = this.GetId(loja);
            this.repositorio.AdicionarOuAtualizar(id, loja);
        }

        public void Atualizar(int id, ILoja loja){

            this.repositorio.AdicionarOuAtualizar(id, loja);
        }
    }
}