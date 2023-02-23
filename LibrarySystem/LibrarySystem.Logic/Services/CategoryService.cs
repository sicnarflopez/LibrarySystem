using LibrarySystem.Data.Context;
using LibrarySystem.Data.Entities;
using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Logic.Services
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        public CategoryService(LibrarySystemDbContext context)
            : base(context)
        {
            
        }

        public async Task<List<Category>> GetCategories()
        {
            return await GetAll().ToListAsync();
        }
    }
}
