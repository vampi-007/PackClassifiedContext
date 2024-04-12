using Microsoft.EntityFrameworkCore;
using PackClassifiedContext.Data.Context;
using PackClassifiedContext.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectStructure.Data.DTO.Handlers
{
    public class AuthorHandler
    {
        public AuthorHandler() { }
        public Author AddAuthor(Author author) {
            using( AuthorContext context = new AuthorContext())
            {
                context.Add(author);
                context.SaveChanges();
            }
            return author;
        }

        public Author? DeleteAuthor(Guid authorId)
        {
            using (AuthorContext context = new AuthorContext())
            {
       

                Author? found = (from a in context.Authors 
                                 where a.Id == authorId
                                 select a).FirstOrDefault();
                if (found != null)
                {
                    context.Remove(found);
                    context.SaveChanges();
                }
                return found;
            }
        }

        public List<Author> GetAuthors() 
        {
            using( AuthorContext context = new AuthorContext())
            {
                return (from a in context.Authors
                        .Include(a=>a.Books)
                        where a != null
                        select a).ToList();
            }
        
        }

        public List<Author> SortAuthor()
        {
            using(AuthorContext context = new AuthorContext())
            {
                return (from a in context.Authors
                        .Include(a => a.Books)
                        .OrderBy (a=>a.Name)
                        select a).ToList();
            }
        }
    }
}
