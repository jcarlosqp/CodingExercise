using Marketplace.Domain.Entities;
using Marketplace.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Services
{
    public class PropertyDomainService : IPropertyDomainService
    {
        private readonly IPropertyRepository repository;

        public PropertyDomainService(IPropertyRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddPropertyAsync(Property property)
        {
            //add domain logic if exists

            await this.repository.AddPropertyAsync(property);
        }
    }
}
