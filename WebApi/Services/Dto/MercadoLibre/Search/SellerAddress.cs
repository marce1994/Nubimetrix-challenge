using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class SellerAddress
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("address_line")]
        public string AddressLine { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("state")]
        public State State { get; set; }

        [JsonPropertyName("city")]
        public City City { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    }

}