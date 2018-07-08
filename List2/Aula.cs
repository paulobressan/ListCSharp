using System;
using System.Collections.Generic;
using System.Text;

namespace List2
{
    public class Aula
    {
        public Aula(string titulo, int tempo )
        {
            this.Titulo = titulo;
            this.Tempo = tempo;
        }

        public string Titulo { get; set; }
        public int Tempo { get; set; }
        public override string ToString()
        {
            return $"Titulo: {Titulo}, Tempo: {Tempo}";
        }
    }
}
