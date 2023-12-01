using Locadão.Domain.Entities;
using System.Collections.Generic;

namespace Locadão.Infrastructure.Repositories;

public interface IVeiculoRepository
{
    Veiculo GetById(int id);
    IEnumerable<Veiculo> GetAll();
    void Add(Veiculo veiculo);
    void Update(Veiculo veiculo);
    void Delete(Veiculo veiculo);
}
