using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Locad�o.Infrastructure.configs;

var builder = WebApplication.CreateBuilder(args);

// Adicionar configura��o do DbContext
builder.Services.AddDbContext<LocadaoContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("LocadaoDatabase")));

// Outras configura��es de servi�os, como adicionar controllers, etc.
// Exemplo: builder.Services.AddControllers();

var app = builder.Build();

// Configura��es do app, como app.UseAuthorization(), app.UseRouting(), etc.

app.Run();
