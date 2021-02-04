using Marketplace.Domain.Entities;
using System.Threading.Tasks;

namespace Marketplace.Application.Services.Commands
{
    public interface IPropertyCommand
    {
        Task AddPropertyAsync(Property property);
    }
}