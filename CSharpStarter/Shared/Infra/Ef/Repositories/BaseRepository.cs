using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Infra.Ef.Contexts;
using CSharpStarter.Shared.Infra.Ef.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpStarter.Shared.Infra.Ef.Repositories
{

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly Context _context = null;
        private DbSet<T> entities;
        public BaseRepository(Context context)
        {
            _context = context;
            entities = context.Set<T>();
        }


        public async Task<T> Create(T entity)
        {
            var createdEntity = await entities.AddAsync(entity);
            await _context.SaveChangesAsync();

            return await FindById(createdEntity.Entity.Id);
        }

        public async Task Delete(int id)
        {
            entities.Remove(await FindById(id));
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<T>> FindAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> FindById(int id)
        {
            return await entities.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> Update(int id, T entity)
        {
            var updatedEntity = entities.Update(entity);
            await _context.SaveChangesAsync();

            return await FindById(updatedEntity.Entity.Id);
        }
    }
}
