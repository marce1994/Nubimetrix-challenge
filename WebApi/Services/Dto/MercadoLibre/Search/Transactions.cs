using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Transactions
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("canceled")]
        public int Canceled { get; set; }

        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("ratings")]
        public Ratings Ratings { get; set; }

        [JsonPropertyName("completed")]
        public int Completed { get; set; }
    }

}