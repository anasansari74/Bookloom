using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
