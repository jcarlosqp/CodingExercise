using Marketplace.Domain.Entities;
using System.Threading.Tasks;

namespace Marketplace.Domain.Interfaces
{
    public interface IPropertyRepository
    {
        Task AddPropertyAsync(Property property);
    }
}
