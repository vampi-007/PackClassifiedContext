using Microsoft.EntityFrameworkCore;
using PackClassifiedContext.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackClassifiedContext.Data.DTO.Handlers
{
    public class BooksHandler
    {
        public BooksHandler() { }

        public Books AddBook(Books book)
        {
            using (AuthorContext context = new AuthorContext())
            {
                context.Add(book);
                context.SaveChanges();
                
            }
            return book;
        }
        public Books RemoveBook(Guid bookId) {

            using (AuthorContext context = new AuthorContext())
            {
                Books? found = (from a in context.Books
                                where a.Id == bookId
                                select a).FirstOrDefault();
                if (found != null)
                {
                    context.Remove(found);
                    context.SaveChanges();
                }
                return found;
            }
        }


        public Books? UpdateBook(Guid idToUpdate, Books book)
        {
            Books? found = null;
            using (AuthorContext context = new AuthorContext())
            {
                found = (from b in context.Books
                         where b.Id == idToUpdate
                         select b).FirstOrDefault();
            }
            if (found != null)
            {
                using (AuthorContext context = new AuthorContext())
                {
                    //book.Id = idToUpdate;
                   
                    context.Books.Remove(found);
                    context.Add(book);
                    context.SaveChanges();
                }
                return book;
            }
            return null;
        }
        public List<Books>? GetByGenre(string genre)
        {
            using (AuthorContext context = new AuthorContext())
            {
                return ((from a in context.Books
                          .Include(a => a.Author)
                         where a.Genre.Equals(genre)
                         select a).ToList());
            }
        }
        public List<Books>? GetBooksByPrice(double price)
        {
            using(AuthorContext context = new AuthorContext())
            {
                return (from a in context.Books
                         .Include(a => a.Author)
                         where a.Price >= price
                         select a).ToList();
            }
        }
    }

}
