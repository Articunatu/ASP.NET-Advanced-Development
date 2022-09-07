using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_SUT21.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions options): base(options)  {   }

        public DbSet<Transaction> Transcations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
