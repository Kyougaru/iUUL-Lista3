using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace iUUL_Lista_3
{
    public class JsonIO
    {
        public List<ClienteJson> ReadData(string path)
        {
            var clientes = JsonSerializer.Deserialize<List<ClienteJson>>(File.ReadAllText(path));
            return clientes;
        }

        public void GenerateErrors(List<ErrosJson> errosJson)
        {
            string json = JsonSerializer.Serialize(errosJson, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("erros.json", json);
        }
    }
}
