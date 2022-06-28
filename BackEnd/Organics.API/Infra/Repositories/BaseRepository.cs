using Organics.API.Domain.Repositorie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organics.API.Infra.Repositories
{
    public class BaseRepository<T> : IRepository<T>
    {
        protected List<T> _list;
        public BaseRepository()
        {
            _list = new List<T>();
        }
        public async Task<T> Create(T entity)
        {
            _list.Add(entity);
            return entity;
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Get()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _list;
        }

        public Task<T> Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
