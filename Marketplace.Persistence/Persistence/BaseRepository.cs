using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketplace.Infrastucture.Persistence
{
    public class BaseRepository<T> where T : class
    {
        private readonly DbContext context;

        public BaseRepository(DbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(T type)
        {
            this.context.Add<T>(type);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await this.context.Set<T>().ToListAsync();
        }
    }
}
