using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class SellerReputation
    {
        [JsonPropertyName("transactions")]
        public Transactions Transactions { get; set; }

        [JsonPropertyName("power_seller_status")]
        public string PowerSellerStatus { get; set; }

        [JsonPropertyName("metrics")]
        public Metrics Metrics { get; set; }

        [JsonPropertyName("level_id")]
        public string LevelId { get; set; }
    }

}