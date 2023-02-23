using LibrarySystem.Data.Entities;
using static LibrarySystem.Logic.Services.BookService;

namespace LibrarySystem.Logic.Services.Interfaces
{
    public interface IBookService : IServiceBase<Book>
    {
        List<Book> GetBooksFromSp();
        Task<List<Book>> GetBooksBySubCategoryId(int Id);
    }
}
