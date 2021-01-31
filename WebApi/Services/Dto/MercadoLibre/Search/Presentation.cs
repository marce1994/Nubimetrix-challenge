using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Presentation
    {
        [JsonPropertyName("display_currency")]
        public string DisplayCurrency { get; set; }
    }

}