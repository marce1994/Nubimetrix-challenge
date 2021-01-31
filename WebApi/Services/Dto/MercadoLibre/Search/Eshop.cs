using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Eshop
    {
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        [JsonPropertyName("eshop_rubro")]
        public object EshopRubro { get; set; }

        [JsonPropertyName("eshop_id")]
        public int EshopId { get; set; }

        [JsonPropertyName("eshop_locations")]
        public List<object> EshopLocations { get; set; }

        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }

        [JsonPropertyName("eshop_logo_url")]
        public string EshopLogoUrl { get; set; }

        [JsonPropertyName("eshop_status_id")]
        public int EshopStatusId { get; set; }

        [JsonPropertyName("seller")]
        public int Seller { get; set; }

        [JsonPropertyName("eshop_experience")]
        public int EshopExperience { get; set; }
    }

}