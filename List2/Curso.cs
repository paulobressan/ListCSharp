using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace List2
{
    public class Curso
    {
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void AdicionarAula(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private List<Aula> aulas;

        public IList<Aula> Aulas
        {
            //Protegento a lista e retornando somente como leitura.
            get { return new ReadOnlyCollection<Aula>(aulas); }         
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string instrutor;

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

       public int TempoTotal
        {   
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //    total += aula.Tempo;
                //return total;
                //Somando com Linq e Lambda
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso : {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",",aulas)}";
        }
    }
}
