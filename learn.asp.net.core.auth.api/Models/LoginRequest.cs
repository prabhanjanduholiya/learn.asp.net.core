using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn.asp.net.core.auth.api.Models
{
    public class LoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
