using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Value
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("struct")]
        public Struct Struct { get; set; }

        [JsonPropertyName("source")]
        public object Source { get; set; }

        [JsonPropertyName("path_from_root")]
        public List<PathFromRoot> PathFromRoot { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }
    }

}