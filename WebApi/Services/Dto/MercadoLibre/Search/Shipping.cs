using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Shipping
    {
        [JsonPropertyName("free_shipping")]
        public bool FreeShipping { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("logistic_type")]
        public string LogisticType { get; set; }

        [JsonPropertyName("store_pick_up")]
        public bool StorePickUp { get; set; }
    }

}