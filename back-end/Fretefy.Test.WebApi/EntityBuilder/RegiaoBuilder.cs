using Fretefy.Test.Domain.Entities;
using Fretefy.Test.WebApi.ViewModel;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.EntityBuilder
{
    public static class RegiaoBuilder
    {
        public static Regiao Builder(RegiaoViewModel regiaoViewModel)
        {
            List<RegiaoCidade> cidades = new List<RegiaoCidade>();
            regiaoViewModel.Cidades
                .ForEach(c => cidades.Add(new RegiaoCidade(c.CidadeId)));

            return new Regiao()
            {   
                Id = regiaoViewModel.Id,
                Ativo = regiaoViewModel.Ativo,
                Nome = regiaoViewModel.Nome,
                Cidades = cidades
            };
        }

        public static IEnumerable<RegiaoViewModel> BuildViews(IEnumerable<Regiao> regioes)
        {
            List<RegiaoViewModel> list = new List<RegiaoViewModel>();
            foreach (var regiao in regioes)
            {
                List<RegiaoCidadeViewModel> idCidades = new List<RegiaoCidadeViewModel>();
                foreach (var c in regiao.Cidades)
                {
                    idCidades.Add(new RegiaoCidadeViewModel() 
                        {
                            RegiaoId = c.RegiaoId, 
                        CidadeId = c.CidadeId });
                }

                list.Add(new RegiaoViewModel()
                {
                    Id = regiao.Id,
                    Ativo = regiao.Ativo,
                    Nome = regiao.Nome,
                    Cidades = idCidades
                }); ;
            }

            return list;
        }
    }
}
