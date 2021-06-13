using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreMVC5.Models;

namespace AspNetCoreMVC5.Data
{
    public class AspNetCoreMVC5Context : DbContext
    {
        public AspNetCoreMVC5Context (DbContextOptions<AspNetCoreMVC5Context> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreMVC5.Models.Movie> Movie { get; set; }
    }
}
