using Server.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
    }
}
