using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final2.Models;

namespace Final2.Data
{
    public class Final2Context : DbContext
    {
        public Final2Context (DbContextOptions<Final2Context> options)
            : base(options)
        {
        }

        public DbSet<Final2.Models.Department> Department { get; set; } = default!;
    }
}
