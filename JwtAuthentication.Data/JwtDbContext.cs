using JwtAuthentication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Data
{
    public class JwtDbContext:DbContext
    {
        public JwtDbContext(DbContextOptions<JwtDbContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
