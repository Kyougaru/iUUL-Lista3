using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace iUUL_Lista_3
{
    public enum ErrosClientes
    {
        Nome,
        Cpf,
        DataNasc,
        RendaMensal,
        EstadoCivil,
        Dependentes
    }

    public class Validador
    {

        public IDictionary<Enum, string> ValidarCliente(string nome, string cpf, string dataNasc, string rendaMensal, string estadoCivil, string dependentes)
        {
            IDictionary<Enum, string> erros = new Dictionary<Enum, string>();
            char[] validos = { 'C', 'S', 'V', 'D', 'c', 's', 'v', 'd' };

            if (nome.Length < 5)
            {
                erros.Add(ErrosClientes.Nome, "Erro no campo Nome: " + nome +
                    "\nNome deve conter pelo menos 5 caracteres");
            }
            if (!long.TryParse(cpf, out long cpfValido) || cpf.Length != 11)
            {
                erros.Add(ErrosClientes.Cpf, "Erro no campo CPF: " + cpf +
                    "\nCPF deve conter números e exatamente 11 caracteres");
            }
            if (!DateTime.TryParseExact(dataNasc, format: "dd/MM/yyyy", provider: new CultureInfo("pt-BR"),
                DateTimeStyles.None, out DateTime dataValida))
            {
                erros.Add(ErrosClientes.DataNasc, "Erro no campo Data de nascimento: " + dataNasc +
                    "\nData de nascimento deve ter o formato DD/MM/AAAA");
            }
            else
            {
                DateTime dataAtual = DateTime.Today;
                int idade = dataAtual.Year - dataValida.Year;

                if (idade < 18)
                {
                    erros.Add(ErrosClientes.DataNasc, "Erro no campo Data de nascimento: " + dataNasc +
                    "\nO cliente deve ter pelo menos 18 anos na data atual");
                }
            }
            if (!float.TryParse(rendaMensal, NumberStyles.Currency, new CultureInfo("pt-BR"), out float rendaValida) || rendaValida < 0)
            {
                erros.Add(ErrosClientes.RendaMensal, "Erro no campo Renda mensal: " + rendaMensal +
                    "\nRenda mensal deve ser maior que zero, ter duas casas decimais e vírgula decimal");
            }
            if (!char.TryParse(estadoCivil, out char estadoValido) || !validos.Contains(estadoValido))
            {
                erros.Add(ErrosClientes.EstadoCivil, "Erro no campo Estado civil: " + estadoCivil +
                    "\nEstado civil deve ser C, S, V ou D (maiusculo ou minusculo)");
            }
            if (!int.TryParse(dependentes, out int dependentesValidos) || (dependentesValidos < 0 || dependentesValidos > 10))
            {
                erros.Add(ErrosClientes.Dependentes, "Erro no campo Dependentes: " + dependentes +
                    "\nDependentes devem ser de 0 a 10");
            }

            return erros;
        }
    }
}
