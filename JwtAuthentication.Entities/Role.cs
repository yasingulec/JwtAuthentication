using JwtAuthentication.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Entities
{
   public class Role:BaseEntity
    {
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }

    }
}
