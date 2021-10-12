using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpStarter.Shared.Infra
{
    public interface IController<T>
    {
        [HttpGet]
        public Task<ICollection<T>> GetAsync();

        [HttpGet("{id}")]
        public Task<T> GetAsync(int id);

        [HttpPost]
        public Task<T> PostAsync([FromBody] T user);

        [HttpPut("{id}")]
        public Task<T> Put(int id, [FromBody] T user);

        [HttpDelete("{id}")]
        public Task DeleteAsync(int id);
       
    }
}
