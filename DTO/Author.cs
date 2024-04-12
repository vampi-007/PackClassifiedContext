using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackClassifiedContext.Data.DTO
{
    public class Author : Entity<Guid>
    {
        public string Name { get; set; }
        public string Type {  get; set; }
        public string Description { get; set; }

        public virtual List<Books> Books { get; set; }
        public Author() { }
    }
}
