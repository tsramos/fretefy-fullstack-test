using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : BaseRepository<Regiao>, IRegiaoRepository
    {
        public RegiaoRepository(TestDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Regiao regiao)
        {
            await _context.AddRangeAsync(regiao);
            _context.SaveChanges();
        }

        public async Task<bool> PossuiCidade(Guid idRegiao, Guid idCidade)
        {
            int count = await _context.Set<RegiaoCidade>()
                                .CountAsync(x => x.RegiaoId == idRegiao &&
                                       x.CidadeId == idCidade);
            return count > 0;
        }

        public async Task<bool> ExisteRegiao(string nome)
        {
            int count = await this.Get().Where(x => x.Nome == nome).CountAsync();
            return count > 0;
        }

        public async Task Update(Regiao regiao)
        {
            _context.Update(regiao);
            await _context.SaveChangesAsync();
        }

        public List<Regiao> GetRegiaoCompleta()
        {
            return this.Get().Include(x => x.Cidades).ToList();
        }
    }
}
