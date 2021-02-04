using Newtonsoft.Json;

namespace Marketplace.Infrastucture.Models
{
    public class Financial
    {
        [JsonProperty(PropertyName = "listPrice")]
        public double ListPrice { get; set; }

        [JsonProperty(PropertyName = "monthlyRent")]
        public double MonthlyRent { get; set; }
    }
}
