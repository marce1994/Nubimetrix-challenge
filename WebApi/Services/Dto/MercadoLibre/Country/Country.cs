using Newtonsoft.Json;

namespace WebApi.Services.Dto.MercadoLibre.Country
{
    public class Country
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }
    }
}
