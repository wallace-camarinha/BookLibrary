using BookLibrary.Data;
using BookLibrary.DTO;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryContext _context;
        public BooksController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAll()
        {
            var books = await _context.Books.ToListAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(CreateOrUpdateBookDTO bookData)
        {
            var book = new Book
                (
                    title: bookData.Title,
                    description: bookData.Description,
                    releaseMonth: bookData.ReleaseMonth,
                    releaseYear: bookData.ReleaseYear,
                    publisher: bookData.Publisher,
                    numberOfPages: bookData.NumberOfPages,
                    authorId: bookData.AuthorId
                );

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return Ok(book);
        }
    }
}
