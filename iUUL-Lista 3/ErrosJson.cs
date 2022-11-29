using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace iUUL_Lista_3
{
    public class ErrosJson
    {
        [JsonPropertyName("dados")]
        public ClienteJson Dados { get; private set; }

        [JsonPropertyName("erros")]
        public IDictionary<string, string> Erros { get; private set; }

        public ErrosJson(ClienteJson cliente, IDictionary<Enum, string> erros)
        {
            Dados = cliente;
            Erros = erros.Keys.ToDictionary(p => p.ToString(), p => erros[p]);
        }
    }
}
