using IdentityAPI.Domain.Entities.Common;

namespace IdentityAPI.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : Entity
    {
        Task<bool> AddAsync(T model);
    }
}
