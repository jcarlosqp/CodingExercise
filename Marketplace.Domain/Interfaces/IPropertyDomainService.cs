using Marketplace.Domain.Entities;
using System.Threading.Tasks;

namespace Marketplace.Domain.Interfaces
{
    public interface IPropertyDomainService
    {
        Task AddPropertyAsync(Property property);
    }
}