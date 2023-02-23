using LibrarySystem.Data.Entities;

namespace LibrarySystem.Logic.Services.Interfaces
{
    public interface ISubCategoryService : IServiceBase<SubCategory>
    {
        Task<List<SubCategory>> GetAllByCategoryId(int id);
    }
}
