﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthentication.Models
{
    public class AuthenticationModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
