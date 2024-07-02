using Fretefy.Test.Domain.Entities;
using System;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoCidadeRepository : IBaseRepository<RegiaoCidade>
    {
        void DeleteCidades(Guid regiaoId);
    }
}
