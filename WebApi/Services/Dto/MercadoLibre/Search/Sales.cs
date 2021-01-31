using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Sales
    {
        [JsonPropertyName("period")]
        public string Period { get; set; }

        [JsonPropertyName("completed")]
        public int Completed { get; set; }
    }

}