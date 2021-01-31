using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Cancellations
    {
        [JsonPropertyName("rate")]
        public double Rate { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }
    }

}