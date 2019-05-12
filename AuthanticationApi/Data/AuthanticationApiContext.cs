using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuthanticationApi.Models
{
    public class AuthanticationApiContext : DbContext
    {
        public AuthanticationApiContext (DbContextOptions<AuthanticationApiContext> options)
            : base(options)
        {
        }

        public DbSet<AuthanticationApi.Models.User> User { get; set; }
    }
}
