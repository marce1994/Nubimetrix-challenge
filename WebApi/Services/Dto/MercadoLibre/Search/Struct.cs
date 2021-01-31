using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Struct
    {
        [JsonPropertyName("number")]
        public float Number { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

}