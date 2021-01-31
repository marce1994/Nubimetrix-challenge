using System.Text.Json.Serialization;

namespace WebApi.ViewModel
{
    public class ResultViewModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("seller_id")]
        public int SellerId { get; set; }

        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }
    }
}
