using Locadão.Domain.Entities;
using Locadão.Domain.entitys;
using Microsoft.EntityFrameworkCore;

namespace Locadão.Infrastructure.configs;

public class LocadaoContext : DbContext
{
    public LocadaoContext(DbContextOptions<LocadaoContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Veiculo> Veiculos { get; set; }
    public DbSet<Locacao> Locacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Aqui você pode configurar mapeamentos específicos se necessário
    }
}
