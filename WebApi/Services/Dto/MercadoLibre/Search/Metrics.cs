using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Metrics
    {
        [JsonPropertyName("claims")]
        public Claims Claims { get; set; }

        [JsonPropertyName("delayed_handling_time")]
        public DelayedHandlingTime DelayedHandlingTime { get; set; }

        [JsonPropertyName("sales")]
        public Sales Sales { get; set; }

        [JsonPropertyName("cancellations")]
        public Cancellations Cancellations { get; set; }
    }

}