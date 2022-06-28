using Organics.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organics.API.Domain.Repositorie
{
    public interface IProviderRepositorie : IRepository<Provider>
    {

    }

    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}
