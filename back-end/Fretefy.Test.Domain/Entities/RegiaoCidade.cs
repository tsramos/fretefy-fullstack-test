using System;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade : Entity 
    {
        public Regiao Regiao { get; set; }
        public Guid RegiaoId { get; set; }

        public Cidade Cidade { get; set; }
        public Guid CidadeId { get; set; }
        
    }

}
