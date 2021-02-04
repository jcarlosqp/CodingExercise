using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Infrastucture.Models
{
    public class Physical
    {
        [JsonProperty(PropertyName = "yearBuilt")]
        public int YearBuilt { get; set; }
    }
}
