using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class DifferentialPricing
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

}