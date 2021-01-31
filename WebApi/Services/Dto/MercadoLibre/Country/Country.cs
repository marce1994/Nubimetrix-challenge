using System.Text.Json.Serialization;

namespace WebApi.Services.Dto.MercadoLibre.Country
{
    public class Country
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }
    }
}
