using System.Collections.Generic;

namespace Q2
{
    public class Palavra
    {
        public string Caracteres { get; private set; }
        public List<int> Linhas { get; private set; }
        public int Repeticoes { get; set; }

        public Palavra(string caracteres, List<int> linhas)
        {
            Caracteres = caracteres;
            Linhas = linhas;
        }

        public override bool Equals(object obj)
        {
            return obj is Palavra p &&
                Caracteres.Equals(p.Caracteres);
        }
    }
}
