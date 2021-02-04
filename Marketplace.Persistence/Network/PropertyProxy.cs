using Marketplace.Infrastucture.Common;
using Marketplace.Infrastucture.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Infrastucture.Network
{
    public class PropertyProxy : IPropertyProxy
    {
        private IConfiguration _config;
        private string _urlBase { get; set; }

        public PropertyProxy(IConfiguration config)
        {
            _config = config;
            _urlBase = _config["PropertiesUrl"].ToString();
        }
        public async Task<PropertiesResponse> GetAsync()
        {
            var Url = new Uri(this._urlBase);

            var response = await WebClientWrapper.GetAsync<PropertiesResponse>(Url);

            return response;
        }
    }
}
