using LibrarySystem.Data.Context;
using LibrarySystem.Data.Entities;
using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Logic.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        public BookService(LibrarySystemDbContext context)
            : base(context)
        {
        }

        //SP Exec
        public List<Book> GetBooksFromSp()
        {
            return _context.Books.FromSqlInterpolated($"exec GetBooks").ToList();
        }

        public async Task<List<Book>> GetBooksBySubCategoryId(int Id)
        {
            return await GetAll().Where(x => x.SubCategoryId == Id)
                                 .Include(x => x.Author)
                                 .ToListAsync();
        }
    }
}
