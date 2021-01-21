using JwtAuthentication.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T:class, IEntity, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
    }
}
