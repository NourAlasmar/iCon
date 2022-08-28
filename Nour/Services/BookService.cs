using Nour.Enums;
using Nour.Models;

namespace Nour.Services
{
    public class BookService : IBookService
    {
        private static List<Book> books = new List<Book>
        {
         new Book(),
         new Book()
         {
             Id = 2,
             Name = "Bired",
             MyCategories = Categories.Fantasy
         },
         new Book()
         {
             Id = 3,
             Name = "New World",
             MyCategories = Categories.Adventure
         }

        };
        public async Task<List<Book>> CreateBook(Book newBook)
        {
            books.Add(newBook);
            return (books);
        }

        public async Task<List<Book>> DeleteBook(int id)
        {
            Book book = books.First(x => x.Id == id);
            books.Remove(book);
            return (books);
        }

        public async Task<List<Book>> GetBooks()
        {
            return books;
        }

        public async Task<Book> GetById(int id)
        {
            return (books.First(x => x.Id == id));
        }

        /**/
        /**/
        public async Task<List<Book>> UpdateBook(Book updateBook)
        {
        ;
            Book book = books.First(x => x.Id == updateBook.Id);
            book.Name = updateBook.Name;
            book.MyCategories = updateBook.MyCategories;
            return (books);
        }
    }
}
