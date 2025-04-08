using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Localstockk.Domain;
using Microsoft.EntityFrameworkCore;

namespace Localstockk.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        private readonly string DB_URL = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DB_URL);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }


    }
}
