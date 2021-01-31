using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Installments
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("rate")]
        public double Rate { get; set; }

        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }
    }

}