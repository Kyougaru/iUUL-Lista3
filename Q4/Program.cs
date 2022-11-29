using System.Collections.Generic;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(1);
            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(3);

            listaNumeros.ImprimeLista();

            List<string> listaStrings = new List<string>();
            listaStrings.Add("Gabriel");
            listaStrings.Add("Gabriel");
            listaStrings.Add("Rafael");

            listaStrings.ImprimeLista();

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(new Cliente("12312312312", "Gabriel"));
            listaClientes.Add(new Cliente("12312312312", "Rafael"));
            listaClientes.Add(new Cliente("15452617892", "Caio"));

            listaClientes.ImprimeLista();
        }
    }
}
