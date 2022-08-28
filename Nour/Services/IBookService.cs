using Microsoft.AspNetCore.Mvc;
using Nour.Models;

namespace Nour.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks();
        Task<Book> GetById(int id);
        Task<List<Book>> CreateBook(Book newBook);
        Task<List<Book>> UpdateBook(Book updateBook);
        Task<List<Book>> DeleteBook(int id  );

        





    }
}
