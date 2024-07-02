using Fretefy.Test.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : Entity
    {
        IQueryable<T> Get();
        Task<T> GetByIdAsync(Guid id);
    }
}
