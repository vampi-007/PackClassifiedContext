using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackClassifiedContext.Data.DTO;

namespace PackClassifiedContext.Data.Context
{
    public class AuthorContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=EXIACDB5\\SQLEXPRESS;Database=PackClassifiedDB2;User Id=vampi;Password=123;TrustServerCertificate=true;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}
