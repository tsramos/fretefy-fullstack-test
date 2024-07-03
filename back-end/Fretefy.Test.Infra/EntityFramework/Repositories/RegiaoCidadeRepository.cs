using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoCidadeRepository : BaseRepository<RegiaoCidade>, IRegiaoCidadeRepository
    {
        public RegiaoCidadeRepository(TestDbContext context) : base(context)
        {
        }

        public void DeleteCidades(Guid regiaoId)
        {
            var cidades = this.Get().Where(x => x.RegiaoId == regiaoId).ToList();
            _context.RemoveRange(cidades);
            _context.SaveChanges();
        }
    }
}
