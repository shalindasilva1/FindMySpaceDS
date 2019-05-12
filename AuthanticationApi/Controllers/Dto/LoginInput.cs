using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthanticationApi.Controllers.Dto
{
    public class LoginInput
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
