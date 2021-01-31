using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Conditions
    {
        [JsonPropertyName("context_restrictions")]
        public List<object> ContextRestrictions { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("end_time")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("eligible")]
        public bool Eligible { get; set; }
    }

}