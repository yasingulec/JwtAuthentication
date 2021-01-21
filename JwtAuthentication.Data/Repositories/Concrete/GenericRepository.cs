using JwtAuthentication.Core;
using JwtAuthentication.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Data.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity ,new()
    {
        private JwtDbContext _ctx;
        public GenericRepository(JwtDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<T> GetAsync(int id)
        {
            var entity = await _ctx.Set<T>().FirstOrDefaultAsync(x=>x.Id==id);
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _ctx.Set<T>().AsNoTracking().ToListAsync();
            return entities;
        }
    }
}
