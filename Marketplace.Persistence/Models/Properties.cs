using Newtonsoft.Json;

namespace Marketplace.Infrastucture.Models
{
    public class Properties
    {
        [JsonProperty(PropertyName = "physical")]
        public Physical Physical { get; set; }

        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        [JsonProperty(PropertyName = "financial")]
        public Financial Financial { get; set; }
    }
}
