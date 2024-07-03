using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IRegiaoCidadeRepository _regiaoCidadeRepository;

        public RegiaoService(
            IRegiaoRepository regiaoRepository,
            ICidadeRepository cidadeRepository,
            IRegiaoCidadeRepository regiaoCidadeRepository)
        {
            _regiaoRepository = regiaoRepository;
            _cidadeRepository = cidadeRepository;
            _regiaoCidadeRepository = regiaoCidadeRepository;

        }

        public IEnumerable<Regiao> Get()
        {
            return _regiaoRepository.GetRegiaoCompleta();
        }

        public async Task AddRegiao(Regiao regiao)
        {
            await ExisteRegiao(regiao);
            
            if (regiao.Cidades.Any())
            {
                await ExisteCidade(regiao);

                foreach (var cidade in regiao.Cidades)
                {
                    cidade.RegiaoId = regiao.Id;
                }

                await _regiaoRepository.AddAsync(regiao);
            }


        }

        public async Task UpdateRegiao(Regiao regiao)
        {
            await ExisteRegiao(regiao);
            _regiaoCidadeRepository.DeleteCidades(regiao.Id);
            await _regiaoRepository.Update(regiao);
        }

        private async Task ExisteRegiao(Regiao regiao)
        {
            if (await _regiaoRepository.ExisteRegiao(regiao.Nome))
            {
                throw new Exception($"Região com nome {regiao.Nome} já registrada na base de dados");
            }
        }

        private async Task ExisteCidade(Regiao regiao)
        {
            List<string> cidadesExistentes = new List<string>();
            foreach (var cidade in regiao.Cidades)
            {
                if (await _regiaoRepository.PossuiCidade(regiao.Id, cidade.CidadeId))
                {
                    Cidade cidadeBd = await _cidadeRepository.GetByIdAsync(cidade.CidadeId);
                    cidadesExistentes.Add(cidadeBd.Nome);
                }                
            }

            if (cidadesExistentes.Any())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Região {regiao.Nome} já possui as seguintes Cidades:  ");
                cidadesExistentes.ForEach(x => sb.Append(x + ", "));
                throw new Exception(sb.ToString());
            }

        }
    }
}
