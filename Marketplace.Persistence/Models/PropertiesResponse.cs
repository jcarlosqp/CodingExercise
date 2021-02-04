using Newtonsoft.Json;
using System.Collections.Generic;

namespace Marketplace.Infrastucture.Models
{
    public class PropertiesResponse
    {
        [JsonProperty(PropertyName = "properties")]
        public List<Properties> Properties { get; set; }
    }
}
