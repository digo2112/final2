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
        public Final2Context(DbContextOptions<Final2Context> options)
            : base(options)
        {
        }

        //adrian fezx pro mysql
        /*protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"server=localhost;userid=batata;password=brocolis;database=bancoteste2;port=3306");
        }
        */
        // public DbSet<Final2.Models.Department> Department { get; set; } = default!;
        public DbSet<Department> Department { get; set; } = default!; //tirou o final2.models pq ja eh o proprio
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
    }
}
