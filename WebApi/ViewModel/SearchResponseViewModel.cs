using System.Collections.Generic;
using System.Text.Json.Serialization;
using WebApi.Services.Dto.MercadoLibre.Search;

namespace WebApi.ViewModel
{
    public class SearchResponseViewModel
    {
        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }

        [JsonPropertyName("results")]
        public List<ResultViewModel> Results { get; set; }

        [JsonPropertyName("secondary_results")]
        public List<object> SecondaryResults { get; set; }

        [JsonPropertyName("related_results")]
        public List<object> RelatedResults { get; set; }

        [JsonPropertyName("sort")]
        public Sort Sort { get; set; }

        [JsonPropertyName("available_sorts")]
        public List<AvailableSort> AvailableSorts { get; set; }

        [JsonPropertyName("filters")]
        public List<Filter> Filters { get; set; }

        [JsonPropertyName("available_filters")]
        public List<AvailableFilter> AvailableFilters { get; set; }
    }
}
