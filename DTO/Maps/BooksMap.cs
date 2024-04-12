using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackClassifiedContext.Data.DTO.Maps
{
    internal class BooksMap : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            // Table Name
            builder.ToTable("Books");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Basic Constraints
            builder.Property(c => c.Name).HasDefaultValue("name");

            // Make Relations
            builder.HasOne(c => c.Author).WithMany(c => c.Books)
                .HasPrincipalKey(c => c.Id).HasForeignKey(e => e.AuthorId);
        }
    }
}
