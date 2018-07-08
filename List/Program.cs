using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma instancia de uma lista de string
            List<String> MinhaLista = new List<String>();
            //Adicionando elementos na lista
            MinhaLista.Add("Trabalhando com listas.");
            MinhaLista.Add("Teste");
            MinhaLista.Add("Trabalhando com teste.");

            //Metodo imprimir a lista
            Imprimir(MinhaLista);
            Console.WriteLine("*******");

            //Imprimindo o primeiro valor da lista filtradando por Trabalhando.
            Console.WriteLine("A primeira aula 'Trabalhando' é:" + MinhaLista.First(aula => aula.Contains("Trabalhando")));
            //Imprimindo o ultimo valor da lista filtradando por teste.
            Console.WriteLine("A primeira aula 'Trabalhando' é:" + MinhaLista.Last(aula => aula.Contains("teste")));
            //Filtrando o primeiro valor da lista por um valor, porem se não houver nenhum item da lista com o valor filtrado não ocorrera erro.
            Console.WriteLine("A primeira aula 'Trabalhando' é:" + MinhaLista.FirstOrDefault(aula => aula.Contains("kkkk")));

            //Revertendo a lista onde o primeiro vai ser o ultimo e o ultimo o primerio
            //MinhaLista.Reverse();

            //removendo um item de uma lista
            // MinhaLista.RemoveAt(MinhaLista.IndexOf(MinhaLista.Last()));

            //Ordenar lista em ordem alfabetica
            MinhaLista.Sort();
            Imprimir(MinhaLista);
            Console.WriteLine("*******");
            //Capturando intervalo de array e atribuindo a uma outra lista. Passando o inicio e o tamanho depois do inicio gerando o intervalo
            List<String> Copia = MinhaLista.GetRange(MinhaLista.Count - 2, 2);
            Imprimir(Copia);
            Console.WriteLine("*******");
            //Clonando uma lista
            List<String> ListaClonada = new List<string>(MinhaLista);
            Imprimir(ListaClonada);
            Console.WriteLine("*******");
            //Removendo uma faixa de valores ou um intervalo. Removendo os 2 ultimos itens.
            ListaClonada.RemoveRange(ListaClonada.Count - 2, 2);
            Imprimir(ListaClonada);

            List<Aula> aulas = new List<Aula>()
            {
                new Aula(){Nome="beste1", tempo= 1},
                new Aula(){Nome="aeste2", tempo= 2}
            };
            Console.WriteLine("*******");

            ImprimirObjetos(aulas);
            //aulas.Sort();
            Console.WriteLine("*******");
            ImprimirObjetos(aulas);

        }

        private static void ImprimirObjetos(List<Aula> aulas)
        {
            foreach (var aula in aulas)
                Console.WriteLine(aula.Nome);
        }

        public class Aula
        {
            public string Nome { get; set; }
            public int tempo { get; set; }

        }

        private static void Imprimir(List<string> MinhaLista)
        {
            for (var i = 0; i < MinhaLista.Count; i++)
                Console.WriteLine(MinhaLista[i]);
        }
    }
}
