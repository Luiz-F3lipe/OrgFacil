using Organics.API.Domain.Entities;
using Organics.API.Domain.Repositorie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Organics.API.Infra.Repositories
{
    public class ProviderRepositorieWithList : BaseRepository<Provider>, IProviderRepositorie
    {
        public ProviderRepositorieWithList()
        {
            base._list.Add(new Provider()
            {
                Adress = "teste",
                Description = "teste",
                Id = _list.Count + 1,
                Image = "imageurl",
                Name = "Denner",
                PersonImage = "dennerProfile.png"
            });
        }        
    }
}
