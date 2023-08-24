using IdentityAPI.Application.Repositories;
using IdentityAPI.Domain.Entities.Common;
using IdentityAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace IdentityAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : Entity
    {
        readonly IdentityAPIDBContext _context;

        public ReadRepository(IdentityAPIDBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll()
        {
           var query = Table.AsQueryable();
           return query;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            var query = Table.AsQueryable();
            return await query.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
        }
    }
}
