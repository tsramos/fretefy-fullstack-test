using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.ViewModel
{
    public class RegiaoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<RegiaoCidadeViewModel> Cidades { get; set; }
    }
}
