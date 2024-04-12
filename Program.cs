// See https://aka.ms/new-console-template for more information
using PackClassifiedContext.Data.DTO;
using BasicProjectStructure.Data.DTO.Handlers;
using PackClassifiedContext.Data.DTO.Handlers;

AuthorHandler authorHandler = new AuthorHandler();

//authorHandler.AddAuthor(new Author
//{
//    Id = new Guid(),
//    Name = "AAAKtar Ali",
//    Description = "Good Kachii",
//    CreatedBy = "Moiz",
//    CreatedOn = DateTime.Today,
//    UpdatedBy = "",
//    UpdatedOn = DateTime.Now,
//    IsActive = true,
//    IsDeleted = false,
//    Type = "Writter"
//});
//handler.AddAuthor(new Author
//{
//    Id = new Guid(),
//    Name = "Faraz",
//    Description = "Good author",
//    CreatedBy = "Abdulrehman",
//    CreatedOn = DateTime.Today,
//    UpdatedBy = "",
//    UpdatedOn = DateTime.Now,
//    IsActive = true,
//    IsDeleted = false,
//    Type = "Poet"
//});
//authorHandler.DeleteAuthor(new Guid("A2983BA5-97B0-4C14-2638-08DC3C69A399"));
//authorHandler.DeleteAuthor(new Guid("098C9A9E-1519-497A-99FA-08DC3C69BF11"));
BooksHandler booksHandler = new BooksHandler();

//booksHandler.AddBook(new Books
//{
//    AuthorId = new Guid("214A5CF4-A620-402F-8282-08DC3C692330"),
//    Name = "Chugal Khoor",
//    Id = new Guid(),
//    Brand = "Khalid book depot",
//    Genre = "Comedy",
//    Description = "Chugal khoor harami hai bach k rho",
//    Title = "Chugal Khoor ki harkatain",
//    CreatedBy = "Muhammad",
//    CreatedOn = DateTime.Today,
//    UpdatedBy = "",
//    UpdatedOn = DateTime.Now,
//    IsActive = true,
//    IsDeleted = false
//});

//booksHandler.UpdateBook(new Guid("9F874A55-6EAC-4D87-A705-08DC3AC125A7"), new Books
//{
//    AuthorId = new Guid("BBE757EA-8333-463B-3192-08DC3ABD65A4"),
//    Name = "Cheeel",
//    Id = new Guid(),
//    Brand = "Khalid book depot",
//    Genre = "Poetry",
//    Description = "Cheel urdh rha hai",
//    Title = "Udhti Cheel",
//    CreatedBy = "Abdulrehman",
//    CreatedOn = DateTime.Today,
//    UpdatedBy = "",
//    UpdatedOn = DateTime.Now,
//    IsActive = true,
//    IsDeleted = false
//});

//booksHandler.RemoveBook(new Guid("4300B498-5F11-4243-0CD9-08DC3AC0A067"));

//List<Books>? books = booksHandler.GetByGenre("Dark");
List<Books> books = booksHandler.GetBooksByPrice(700);
int no = 1;
foreach (var b in books)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine($"{no}). Name: {b.Name}\nDescription: {b.Description}\nCreated By: {b.CreatedBy}\nTitle: {b.Title}\nPrice: {b.Price}");
    Console.Write("Author Name: ");
    if (b.Author.Name != null) Console.WriteLine(b.Author.Name);
    Console.WriteLine("-----------------------");
    no++;
}


//List<Author> authorList = authorHandler.GetAuthors();
//List<Author> authorList = authorHandler.SortAuthor();

//foreach (Author author in authorList)
//{
//    Console.WriteLine("\n++++++++++++++++++++++++++");
//    Console.WriteLine($"Author Name: {author.Name}\nAuthor Type: {author.Type}");
//    if (author != null)
//    {
//        Console.WriteLine("<<<<<<<<Books>>>>>>>>");
//        int no = 1;
//        foreach (Books b in author.Books)
//        {
//            Console.WriteLine($"{no}). Name: {b.Name}\nDescription: {b.Description}\nCreated By: {b.CreatedBy}\nTitle: {b.Title}\n");
//            no++;
//        }
//    }
//}


Console.WriteLine("Press any key to continue...");
Console.ReadKey();
