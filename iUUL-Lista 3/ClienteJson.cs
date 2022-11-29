using System.Text.Json.Serialization;

namespace iUUL_Lista_3
{
    public class ClienteJson
    {
        [JsonPropertyName("nome")]
        public string Nome { get; private set; }

        [JsonPropertyName("cpf")]
        public string Cpf { get; private set; }

        [JsonPropertyName("dt_nascimento")]
        public string DataNasc { get; private set; }

        [JsonPropertyName("renda_mensal")]
        public string RendaMensal { get; private set; }

        [JsonPropertyName("estado_civil")]
        public string EstadoCivil { get; private set; }

        [JsonPropertyName("dependentes")]
        public string Dependentes { get; private set; }
    }
}
