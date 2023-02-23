using LibrarySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Logic.Services.Interfaces
{
    public interface ICategoryService : IServiceBase<Category>
    {
        Task<List<Category>> GetCategories();
    }
}
