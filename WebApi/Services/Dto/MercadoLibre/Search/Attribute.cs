using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Attribute
    {
        [JsonPropertyName("source")]
        public object Source { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value_id")]
        public string ValueId { get; set; }

        [JsonPropertyName("value_name")]
        public string ValueName { get; set; }

        [JsonPropertyName("value_struct")]
        public ValueStruct ValueStruct { get; set; }

        [JsonPropertyName("values")]
        public List<Value> Values { get; set; }

        [JsonPropertyName("attribute_group_id")]
        public string AttributeGroupId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("attribute_group_name")]
        public string AttributeGroupName { get; set; }
    }

}