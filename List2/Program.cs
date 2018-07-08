using System;
using System.Collections.Generic;
using System.Linq;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpColecoes = new Curso("C# Collections", "Paulo Bressan");
            //Metodo adiciona aulas
            cSharpColecoes.AdicionarAula(new Aula("Trabalhando com Listas", 21));
            //Imprimindo a aulas que é uma lista somente leitura.
            Imprimir(cSharpColecoes.Aulas);

            //Adicionando mais duas aulas.
            cSharpColecoes.AdicionarAula(new Aula("Criando uma aula", 20));
            cSharpColecoes.AdicionarAula(new Aula("Modelando com coleções", 19));
            Imprimir(cSharpColecoes.Aulas);

            //Copiar a lista para outra lista
            var aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);

            //Ordenar a lista de aulas copiada
            var aulasOrdenadas = aulasCopiadas.OrderBy(aula => aula.Titulo).ToList();
            Imprimir(aulasOrdenadas);
            Console.WriteLine(cSharpColecoes.TempoTotal);

            //Imprimir detalhes do curso
            Console.WriteLine(cSharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
                Console.WriteLine(aula.Titulo);
        }
    }
}
