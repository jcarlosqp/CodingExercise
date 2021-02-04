using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Infrastucture.Models
{
    public class Address
    {
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
