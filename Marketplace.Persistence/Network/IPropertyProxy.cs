using Marketplace.Infrastucture.Models;
using System.Threading.Tasks;

namespace Marketplace.Infrastucture.Network
{
    public interface IPropertyProxy
    {
        Task<PropertiesResponse> GetAsync();
    }
}