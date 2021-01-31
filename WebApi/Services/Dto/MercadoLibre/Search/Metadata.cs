using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Metadata
    {
        [JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        [JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; }

        [JsonPropertyName("promotion_type")]
        public string PromotionType { get; set; }
    }

}