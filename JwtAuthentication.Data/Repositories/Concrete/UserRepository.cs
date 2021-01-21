using JwtAuthentication.Data.Repositories.Interfaces;
using JwtAuthentication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Data.Repositories.Concrete
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        private JwtDbContext _ctx;
        public UserRepository(JwtDbContext ctx):base(ctx)
        {
            _ctx = ctx;
        }

        public async Task<User> Authenticate(string username, string password)
        {
          return await _ctx.Users.FirstOrDefaultAsync(x => x.UserName == username && x.Password == password);
        }
    }
}
