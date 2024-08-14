using Server.DataModels;

namespace Server.Services
{
    public interface IbookService
    {
        //Returns all books in database
        Task<List<Book>> GetAllBooksAsync();
    }
}
