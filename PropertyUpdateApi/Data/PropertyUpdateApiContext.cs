using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PropertyUpdateApi.Models
{
    public class PropertyUpdateApiContext : DbContext
    {
        public PropertyUpdateApiContext (DbContextOptions<PropertyUpdateApiContext> options)
            : base(options)
        {
        }

        public DbSet<PropertyUpdateApi.Models.Property> Property { get; set; }
    }
}
