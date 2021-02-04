using Marketplace.Application.Adapters;
using Marketplace.Domain.Entities;
using Marketplace.Infrastucture.Network;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Application.Services.Queries
{
    public class PropertyQuery : IPropertyQuery
    {
        private readonly IPropertyProxy proxy;

        public PropertyQuery(IPropertyProxy proxy)
        {
            this.proxy = proxy;
        }
        public async Task<IEnumerable<Property>> GetAsync()
        {
            var response = await this.proxy.GetAsync();
            var properties = response.Properties.Select(p => PropertyAdapter.CreateProperty(p));
            return properties.ToList();
        }
    }
}
