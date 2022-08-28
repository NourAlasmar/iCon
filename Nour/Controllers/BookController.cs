using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nour.Enums;
using Nour.Models;
using Nour.Services;

namespace Nour.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        public IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;

            var x = 1;
        }
        
        [HttpGet("GetBooks")]
        public async Task<ActionResult<List<Book>>> Get()
        {
            return Ok(_bookService.GetBooks());
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Book>> GetById(int id)
        {

            return Ok(_bookService.GetById(id));
        }

        [HttpPost("NewBook")]

        public async Task<ActionResult<List<Book>>> CreateBook(Book newBook)
        {

            return Ok(_bookService.CreateBook(newBook));
        }

        [HttpPut("Update")]
        public async Task<ActionResult<List<Book>>> UpdateBook(Book updateBook)
        {

            return Ok(_bookService.UpdateBook(updateBook));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<List<Book>>> DeleteBook(int id)
        {

            return Ok(_bookService.DeleteBook(id));
        }

    }
}
