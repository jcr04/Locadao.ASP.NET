using Locadão.Domain.Entities;
using Locadão.Infrastructure.configs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Locadão.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly LocadaoContext _context;

    public ClienteRepository(LocadaoContext context)
    {
        _context = context;
    }

    public Cliente GetById(int id)
    {
        return _context.Clientes.FirstOrDefault(c => c.Id == id);
    }

    public IEnumerable<Cliente> GetAll()
    {
        return _context.Clientes.ToList();
    }

    public void Add(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
    }

    public void Update(Cliente cliente)
    {
        _context.Entry(cliente).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(Cliente cliente)
    {
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
    }
}
