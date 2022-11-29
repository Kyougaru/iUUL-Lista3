using System;
using System.Globalization;

namespace iUUL_Lista_3
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public long Cpf { get; private set; }

        public DateTime DataNasc { get; private set; }

        public float RendaMensal { get; private set; }

        public char EstadoCivil { get; private set; }

        public int Dependentes { get; private set; }

        public Cliente(string nome, string cpf, string dataNasc, string rendaMensal, string estadoCivil, string dependentes)
        {
            Nome = nome;
            Cpf = long.Parse(cpf);
            DataNasc = DateTime.ParseExact(s: dataNasc, format: "dd/MM/yyyy", provider: new CultureInfo("pt-BR"));
            RendaMensal = float.Parse(rendaMensal, new CultureInfo("pt-BR"));
            EstadoCivil = char.Parse(estadoCivil);
            Dependentes = int.Parse(dependentes);
        }
    }
}
