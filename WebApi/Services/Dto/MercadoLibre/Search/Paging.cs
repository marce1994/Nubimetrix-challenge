using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Paging
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("primary_results")]
        public int PrimaryResults { get; set; }

        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }
    }

}