using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly TestDbContext _context;
        public BaseRepository(TestDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Get() => this._context.Set<T>();

        public async Task<T> GetByIdAsync(Guid id) => await Get().SingleAsync(x => x.Id == id);
    }
}
