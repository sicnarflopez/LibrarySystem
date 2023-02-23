using LibrarySystem.Data.Context;
using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Logic.Services
{
    public class ServiceBase<Entity> : IServiceBase<Entity>
        where Entity : class, IEntity
    {
        protected readonly LibrarySystemDbContext _context;

        public ServiceBase(LibrarySystemDbContext context)
        {
            _context = context;
        }

        public IQueryable<Entity> GetAll()
        {
            return _context.Set<Entity>().AsNoTracking();
        }
        public async Task<Entity> GetById(int id)
        {
            return await _context.Set<Entity>()
                                 .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
