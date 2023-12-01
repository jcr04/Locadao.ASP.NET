using Locadão.Domain.Entities;

namespace Locadão.Infrastructure.Repositories;

public interface IClienteRepository
    {
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);
    }

