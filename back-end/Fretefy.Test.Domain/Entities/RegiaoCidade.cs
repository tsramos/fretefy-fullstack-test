using System;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade : Entity
    {
        public RegiaoCidade()
        {
        }

        public RegiaoCidade(Guid cidadeId)
        {
            CidadeId = cidadeId;
        }

        public Regiao Regiao { get; set; }
        public Guid RegiaoId { get; set; }
        public Cidade Cidade { get; set; }
        public Guid CidadeId { get; set; }

    }

}
