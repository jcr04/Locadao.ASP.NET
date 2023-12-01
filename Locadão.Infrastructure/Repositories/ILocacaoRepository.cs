using Locadão.Domain.Entities;
using System.Collections.Generic;

namespace Locadão.Infrastructure.Repositories;

public interface ILocacaoRepository
{
    Locacao GetById(int id);
    IEnumerable<Locacao> GetAll();
    void Add(Locacao locacao);
    void Update(Locacao locacao);
    void Delete(Locacao locacao);
}
