using Marketplace.Domain.Entities;
using Marketplace.Domain.Interfaces;
using Marketplace.Infrastucture.Persistence.Data;
using System.Threading.Tasks;

namespace Marketplace.Infrastucture.Persistence
{
    public class PropertyRepository : BaseRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(AppDBContext context): base(context)
        {
        }
        public async Task AddPropertyAsync(Property property)
        {
            await base.AddAsync(property);
        }
    }
}
