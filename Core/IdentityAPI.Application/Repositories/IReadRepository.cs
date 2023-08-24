using IdentityAPI.Domain.Entities.Common;

namespace IdentityAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(string id);
    }
}
