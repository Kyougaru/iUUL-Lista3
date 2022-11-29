using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Q2
{
    public class IndiceRemissivo
    {
        public List<Palavra> Palavras { get; private set; }

        public IndiceRemissivo(string pathTXT, string pathIgnore)
        {
            Palavras = new List<Palavra>();
            List<string> palavrasIgnoradas = new List<string>();

            char[] caracteresIgnorados = new char[] { ' ', '\n', '\r', '.', ',', ';', '<', '>', '\\', '/', '|', '~', '^',
            '´', '`', '[', ']', '{', '}', '‘', '“', '!', '@', '#', '$', '%', '&', '*', '(', ')', '_', '+', '='};

            if (!File.Exists(pathTXT))
            {
                throw new Exception("O arquivo pathTXT não existe");
            }

            if (pathIgnore != null)
            {
                if (!File.Exists(pathIgnore))
                {
                    throw new Exception("O arquivo pathIgnore não existe");
                }

                palavrasIgnoradas = File.ReadAllText(pathIgnore).ToLower().Split(caracteresIgnorados, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            using (StreamReader reader = new StreamReader(pathTXT))
            {
                string texto;
                int contador = 1;
                while ((texto = reader.ReadLine()) != null)
                {
                    var palavras = texto.ToLower().Split(caracteresIgnorados, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string palavra in palavras)
                    {
                        if (!palavrasIgnoradas.Contains(palavra) || palavrasIgnoradas == null)
                        {
                            Palavra p = new Palavra(palavra, new List<int> { contador });
                            var mesmaPalavra = Palavras.FirstOrDefault(x => x.Equals(p));

                            if(mesmaPalavra != null)
                            {
                                mesmaPalavra.Linhas.Add(contador);
                                mesmaPalavra.Repeticoes += 1;
                            } else
                            {
                                Palavras.Add(p);
                            }
                        }
                    }
                    contador++;
                }
            }
        }

        public void Imprime()
        {
            List<Palavra> listaOrdenada = Palavras.OrderBy(x => x.Caracteres).ToList();
            foreach (Palavra p in listaOrdenada)
            {
                string[] linhas = p.Linhas.Select(x => x.ToString()).ToArray();
                Console.WriteLine(p.Caracteres + "(" + p.Repeticoes + ")" + " " + String.Join(", ", linhas));
                Console.WriteLine("");
            }
        }
    }
}
