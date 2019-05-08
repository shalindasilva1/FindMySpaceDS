using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PropertReadApi.Models
{
    public class PropertReadApiContext : DbContext
    {
        public PropertReadApiContext (DbContextOptions<PropertReadApiContext> options)
            : base(options)
        {
        }

        public DbSet<PropertReadApi.Models.Property> Property { get; set; }
    }
}
