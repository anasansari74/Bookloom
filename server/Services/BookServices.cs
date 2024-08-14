using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.DataModels;
using Server.Data;

namespace Server.Services
{
    public class BookService : IbookService{
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}