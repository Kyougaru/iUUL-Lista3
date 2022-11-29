using System;
using System.Collections.Generic;

namespace iUUL_Lista_3
{
    public class Controller
    {
        public static void Start()
        {
            JsonIO io = new JsonIO();
            Validador validaCliente = new Validador();
            List<ErrosJson> jsonErros = new List<ErrosJson>();

            IDictionary<Enum, string> erros;

            var clientes = io.ReadData("clientes.json");
            
            foreach(ClienteJson c in clientes)
            {
                erros = validaCliente.ValidarCliente(c.Nome, c.Cpf, c.DataNasc, c.RendaMensal, c.EstadoCivil, c.Dependentes);

                if (erros.Count == 0)
                {
                    Cliente cliente = new Cliente(c.Nome, c.Cpf, c.DataNasc, c.RendaMensal, c.EstadoCivil, c.Dependentes);
                    Console.WriteLine("\nDados do Cliente:");
                    Console.WriteLine("Nome: " + cliente.Nome + " CPF: " + cliente.Cpf + " Data Nasc: " + cliente.DataNasc +
                    " Renda Mensal: " + cliente.RendaMensal + " Estado Civil: " + cliente.EstadoCivil +
                    " Dependentes: " + cliente.Dependentes);
                }
                else
                {
                    jsonErros.Add(new ErrosJson(c, erros));
                }
            }
            io.GenerateErrors(jsonErros);
        }
    }
}
