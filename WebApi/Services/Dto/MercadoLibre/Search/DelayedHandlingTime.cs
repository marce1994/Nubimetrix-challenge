using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class DelayedHandlingTime
    {
        [JsonPropertyName("rate")]
        public double Rate { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }
    }

}