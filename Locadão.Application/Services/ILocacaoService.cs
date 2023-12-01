using Locadão.Application.dtos;
using System.Collections.Generic;

namespace Locadão.Application.Services;

public interface ILocacaoService
{
    LocacaoDTO GetLocacaoById(int id);
    IEnumerable<LocacaoDTO> GetAllLocacoes();
    void AddLocacao(LocacaoDTO locacaoDto);
    void UpdateLocacao(LocacaoDTO locacaoDto);
    void DeleteLocacao(int id);
}
