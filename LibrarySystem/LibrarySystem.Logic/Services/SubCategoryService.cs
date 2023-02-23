using LibrarySystem.Data.Context;
using LibrarySystem.Data.Entities;
using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Logic.Services
{
    public class SubCategoryService : ServiceBase<SubCategory>, ISubCategoryService
    {
        public SubCategoryService(LibrarySystemDbContext context)
            : base(context)
        {

        }

        public async Task<List<SubCategory>> GetAllByCategoryId(int id)
        {
            return await GetAll().Where(s => s.CategoryId == id)
                                 .ToListAsync();
        }
    }
}
