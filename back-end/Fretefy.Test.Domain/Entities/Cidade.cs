using System;

namespace Fretefy.Test.Domain.Entities
{
    public class Cidade : Entity
    {
        public Cidade()
        {            
        }

        public Cidade(string nome, string uf)
        {          
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
        }  

        public string Nome { get; set; }

        public string UF { get; set; }
    }
}
