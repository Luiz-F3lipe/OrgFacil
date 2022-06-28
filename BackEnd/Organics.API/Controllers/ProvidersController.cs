using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Organics.API.Domain.Entities;
using Organics.API.Domain.Repositorie;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organics.API.Controllers
{
    [ApiController]
    [Route("api/v1/Providers")]
    public class ProvidersController : ControllerBase
    {
        private readonly IProviderRepositorie _providerRepositorie;

        public ProvidersController(IProviderRepositorie providerRepositorie)
        {
            this._providerRepositorie = providerRepositorie;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Provider>> GetAll()
        {
            return await _providerRepositorie.GetAll();
        }

        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            return await _providerRepositorie.Delete(id);
        }

        [HttpPost]
        public async Task<Provider> Create([FromBody] Provider provider)
        {
            return await _providerRepositorie.Create(provider);
        }

        [HttpPut]
        public async Task<Provider> Update([FromBody] Provider provider)
        {
            return await _providerRepositorie.Update(provider);
        }
    }
}
