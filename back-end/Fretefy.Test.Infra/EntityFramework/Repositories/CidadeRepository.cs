using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(TestDbContext context) : base(context)
        {            
        }

        public IQueryable<Cidade> List()
        {
            return this.Get();
        }

        public IEnumerable<Cidade> ListByUf(string uf)
        {
            return Get().Where(w => EF.Functions.Like(w.UF, $"%{uf}%"));
        }

        public IEnumerable<Cidade> Query(string terms)
        {

            return Get().Where(w => EF.Functions.Like(w.Nome, $"%{terms}%") || EF.Functions.Like(w.UF, $"%{terms}%"));
        }
    }
}
