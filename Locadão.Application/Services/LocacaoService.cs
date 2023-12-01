using Locadão.Application.dtos;
using Locadão.Domain.Entities;
using Locadão.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Locadão.Application.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }

        public LocacaoDTO GetLocacaoById(int id)
        {
            var locacao = _locacaoRepository.GetById(id);
            if (locacao == null) return null;

            return new LocacaoDTO
            {
                Id = locacao.Id,
                VeiculoId = locacao.VeiculoId,
                DataInicio = locacao.DataInicio,
                DataFim = locacao.DataFim,
                ValorTotal = locacao.ValorTotal
            };
        }

        public IEnumerable<LocacaoDTO> GetAllLocacoes()
        {
            var locacoes = _locacaoRepository.GetAll();
            return locacoes.Select(l => new LocacaoDTO
            {
                Id = l.Id,
                VeiculoId = l.VeiculoId,
                DataInicio = l.DataInicio,
                DataFim = l.DataFim,
                ValorTotal = l.ValorTotal
            }).ToList();
        }

        public void AddLocacao(LocacaoDTO locacaoDto)
        {
            var locacao = new Locacao(
                locacaoDto.VeiculoId,
                locacaoDto.DataInicio,
                locacaoDto.DataFim,
                locacaoDto.ValorTotal
            );

            _locacaoRepository.Add(locacao);
        }

        public void UpdateLocacao(LocacaoDTO locacaoDto)
        {
            var locacao = _locacaoRepository.GetById(locacaoDto.Id);
            if (locacao == null) return;

            locacao.VeiculoId = locacaoDto.VeiculoId;
            locacao.DataInicio = locacaoDto.DataInicio;
            locacao.DataFim = locacaoDto.DataFim;
            locacao.ValorTotal = locacaoDto.ValorTotal;

            _locacaoRepository.Update(locacao);
        }

        public void DeleteLocacao(int id)
        {
            var locacao = _locacaoRepository.GetById(id);
            if (locacao == null) return;

            _locacaoRepository.Delete(locacao);
        }
    }
}
