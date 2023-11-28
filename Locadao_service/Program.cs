using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Locadão.Infrastructure.configs;

var builder = WebApplication.CreateBuilder(args);

// Adicionar configuração do DbContext
builder.Services.AddDbContext<LocadaoContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("LocadaoDatabase")));

// Outras configurações de serviços, como adicionar controllers, etc.
// Exemplo: builder.Services.AddControllers();

var app = builder.Build();

// Configurações do app, como app.UseAuthorization(), app.UseRouting(), etc.

app.Run();
