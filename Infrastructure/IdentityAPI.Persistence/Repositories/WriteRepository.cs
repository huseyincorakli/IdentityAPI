using IdentityAPI.Application.Repositories;
using IdentityAPI.Domain.Entities.Common;
using IdentityAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace IdentityAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : Entity
    {
        readonly IdentityAPIDBContext _context;

        public WriteRepository(IdentityAPIDBContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
           EntityEntry entityEntry = await Table.AddAsync(model);
           return entityEntry.State== EntityState.Added;
        }

        public async Task<int> SaveAsync()
        =>await _context.SaveChangesAsync();
    }
}
