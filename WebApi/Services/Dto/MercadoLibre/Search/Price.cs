using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Price
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("conditions")]
        public Conditions Conditions { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("regular_amount")]
        public int? RegularAmount { get; set; }

        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }

        [JsonPropertyName("exchange_rate_context")]
        public string ExchangeRateContext { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("prices")]
        public List<Price> Prices { get; set; }

        [JsonPropertyName("presentation")]
        public Presentation Presentation { get; set; }

        [JsonPropertyName("payment_method_prices")]
        public List<object> PaymentMethodPrices { get; set; }
    }

}