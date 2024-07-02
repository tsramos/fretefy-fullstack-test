using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : Entity
    {
        public string Nome { get; set; }

        public IEnumerable<RegiaoCidade> Cidades { get; set; }

        public bool Ativo { get; set; }


        public Regiao()
        {                
            Cidades = new List<RegiaoCidade>();
        }

        public Regiao(string nome, IEnumerable<RegiaoCidade> cidades) 
        {
            Nome = nome;
            Cidades = cidades;
            Ativo = true;
        }
    }
}
