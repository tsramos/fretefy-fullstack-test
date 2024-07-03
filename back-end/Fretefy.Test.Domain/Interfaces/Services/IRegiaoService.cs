using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        IEnumerable<Regiao> Get();

        Task AddRegiao(Regiao regiao);

        Task UpdateRegiao(Regiao regiao);
    }
}
