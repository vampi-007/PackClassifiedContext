using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackClassifiedContext.Data.DTO
{
    public class Books : Entity<Guid>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }

        public double Price { get; set; }
        public string Genre { get; set; }

        public Guid AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public Books() { }
    }
}
