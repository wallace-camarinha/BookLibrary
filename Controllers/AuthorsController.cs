using BookLibrary.Data;
using BookLibrary.DTO;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BookLibrary.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly LibraryContext _context;
        public AuthorsController(LibraryContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Author>> Create(CreateOrUpdateAuthorDTO authorData)
        {
            var author = new Author
                (
                    firstName: authorData.FirstName,
                    lastName: authorData.LastName,
                    dateOfBirth: authorData.DateOfBirth
                );

            _context.Authors.Add(author);
            await _context.SaveChangesAsync();

            return Ok(author);
        }

        [HttpGet]
        public async Task<ActionResult<List<Author>>> GetAll()
        {
            var list = _context.Authors.ToListAsync();
            return Ok(list);
        }
    }
}
