using System;

namespace main{

    class Polimorfismo{

        List<ILoja> lojas;

        public Polimorfismo(List<ILoja> _lojas){

            lojas = _lojas;
            var nomes = new List<string>();
        }

        public void ExecutarExemplos(){

            this.Exemplo1Academico();
            this.Exemplo2Investimentos();
            this.Exemplo3LojaShopping();
        }

        //utilizamos a interface IAcademico para designar as pessoas que possuem relação com uma instituição
        //No caso temos dois tipos de pessoa o Professor e o Aluno
        void Exemplo1Academico(){

            Console.WriteLine("Exemplo dos acadêmicos - Início");
            //Exemplo sem polimorfismo, implica que temos que conhecer a responsabilidade de cada um
            //Além é claro de ter uma variável para cada classe    
            Aluno aluno = new Aluno();
            Professor professor = new Professor();

            aluno.Responsabilidade();
            professor.Responsabilidade();

            //Exemplo com polimorfismo
            // Definimos uma unica variavel, que dependendo do contexto (objeto que foi instanciado), pode ter um comportamento ou outro
            IAcademico pessoa = new Aluno();

            pessoa.Responsabilidade();

            pessoa = new Professor();

            pessoa.Responsabilidade();

            Console.WriteLine("Exemplo dos acadêmicos - Fim \n");

        }

        /// <summary>
        /// Simulação de necessidade para a criação de uma forma de todos os investimentos terem como atributos: ValorInicial, ValorAtual e um método que gera rendimentos
        /// </summary>
        void Exemplo2Investimentos(){

            Console.WriteLine("Exemplo dos investimentos - Início");
            //Independente de qual for o investimento escolhido, sabemos que ele terá um método "Render"
            IInvestimento investimento = new Poupanca(1000);
            investimento.Render();
            Console.WriteLine(investimento.ValorAtual);


            investimento = new CDB(1000);
            investimento.Render();
            Console.WriteLine(investimento.ValorAtual);
            Console.WriteLine("Exemplo dos investimentos - Fim \n");
        }
        /// <summary>
        /// Definir uma matriz com as lojas do shopping, Imprimir o nome e valor do aluguel de cada uma e por fim simular o processo de venda, independente da loja.
        /// </summary>
        void Exemplo3LojaShopping()
        {
            Console.WriteLine("Exemplo das Lojas - Início");
            // Matriz de Lojas (objeto mais basico e comum) com a criação de cada loja com seu tipo
            ILoja[] lojas = new ILoja[4] { new FastFood("McDonalds", 50000) //Exemplo de polimorfismo no construtor, em que dependendo de uma entrada ou outra temos diferenças no comportamento
                                        , new FastFood("KFC")
                                         , new LojaDepartamento("Renner")
                                         , new LojaDepartamento("CeA")
                                        };
                                        
            foreach (ILoja loja in lojas){

                Console.WriteLine(loja.Nome);
                Console.WriteLine(loja.Aluguel);
                loja.Vender();
            }

            Console.WriteLine("Exemplo das Lojas - Fim \n");
        }

        public void SelectOption(int option){

            Menu menu = new Menu();

            switch(option){

                case 0:

                    menu.MenuGeral();
                    break;

                case 1:

                    ListarLojasCadastradas();
                    break;

                case 2:

                    menu.MenuShopping();
                    break;
                
                case 3:

                    CadastrarLojaDepartamento();
                    break;

                case 4:

                    CadastrarFastFood();
                    break;

                case 5:

                    RemoverLojaOuFastFood();
                    break;

                default:

                    Console.WriteLine("Opção incorreta, tente novamente\n");
                    break;
            }
        }

        void CadastrarLojaDepartamento(){

            /*Tipos de Collections:
            * - List<>
            * - Dictionary<Tkey, TValue>
            */

            string nomeLoja = "";
            bool novamente = false;

            do{

                Console.WriteLine("Digite o nome da loja de departamento a ser cadastrada: ");
                nomeLoja = Console.ReadLine();

                lojas.Add(new FastFood(nomeLoja, aluguelLoja));

                Console.WriteLine("\nDeseja cadastrar outro FastFoose? Sim ou não (sem acento): ");
                string simNao = Console.ReadLine().ToUpper();

                switch (simNao)
                {
                    case "SIM":

                        novamente = true;
                        break;

                    case "NAO":

                        novamente = false;
                        break;

                    default:

                        Console.WriteLine("Opção inválida, não haverá novo cadastro.");
                        novamente = false;
                        break;
                }

            }while(novamente);
        }

        void RemoverLojaOuFastFood(){

            string nomeLoja;
            Console.WriteLine("Digite o nome da loja de Departamento ou FastFood que deseja remover: ");
            nomeLoja = Console.ReadLine();

            int indexLoja = lojas.FindIndex(loja => loja.Nome == nomeLoja);

            if(indexLoja == -1){

                Console.WriteLine("Loja não encontrada, tente novamente.");
                RemoverLojaOuFastFood();
            }
            else{

                lojas.RemoveAt(indexLoja);
                Console.WriteLine($"A loja {nomeLoja} foi removida com sucesso");
            }
        }

        void ListarLojasCadastradas(){

            Console.WriteLine("Estas são as lojas cadastradas: ");

            foreach (ILoja e in lojas){

                Console.WriteLine($"Loja: {loja.Nome} - Aluguel: {loja.Aluguel}");
            }
        }
    }
}