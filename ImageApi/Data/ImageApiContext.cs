using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImageApi.Models
{
    public class ImageApiContext : DbContext
    {
        public ImageApiContext (DbContextOptions<ImageApiContext> options)
            : base(options)
        {
        }

        public DbSet<ImageApi.Models.Image> Image { get; set; }
    }
}
