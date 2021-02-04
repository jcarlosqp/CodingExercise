using Marketplace.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Application.Services.Queries
{
    public interface IPropertyQuery
    {
        Task<IEnumerable<Property>> GetAsync();
    }
}