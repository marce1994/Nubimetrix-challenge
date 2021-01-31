using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Ratings
    {
        [JsonPropertyName("negative")]
        public double Negative { get; set; }

        [JsonPropertyName("positive")]
        public double Positive { get; set; }

        [JsonPropertyName("neutral")]
        public double Neutral { get; set; }
    }

}