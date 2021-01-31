using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Address
    {
        [JsonPropertyName("state_id")]
        public string StateId { get; set; }

        [JsonPropertyName("state_name")]
        public string StateName { get; set; }

        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        [JsonPropertyName("city_name")]
        public string CityName { get; set; }
    }

}