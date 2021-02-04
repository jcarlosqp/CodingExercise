using Marketplace.Domain.Entities;
using Marketplace.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Application.Services.Commands
{
    public class PropertyCommand : IPropertyCommand
    {
        private readonly IPropertyDomainService domainService;

        public PropertyCommand(IPropertyDomainService domainService)
        {
            this.domainService = domainService;
        }

        public async Task AddPropertyAsync(Property property)
        {
            await this.domainService.AddPropertyAsync(property);
        }
    }
}
