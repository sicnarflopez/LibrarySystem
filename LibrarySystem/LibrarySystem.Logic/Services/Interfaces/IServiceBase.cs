using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Logic.Services.Interfaces
{
    public interface IServiceBase<Entity>
        where Entity : class, IEntity
    {
        IQueryable<Entity> GetAll();
        Task<Entity> GetById(int id);
    }
}
