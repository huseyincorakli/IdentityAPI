using IdentityAPI.Domain.Entities.Common;

namespace IdentityAPI.Application.Repositories
{
    public interface IRepository<T> where T : Entity
    {
    }
}
