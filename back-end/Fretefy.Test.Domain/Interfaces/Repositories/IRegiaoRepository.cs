using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository : IBaseRepository<Regiao>
    {
        Task<bool> PossuiCidade(Guid idRegiao, Guid idCidade);
        Task AddAsync(Regiao regiao);
        List<Regiao> GetRegiaoCompleta();
        Task<bool> ExisteRegiao(string nome);

        Task Update(Regiao regiao);

    }
}
