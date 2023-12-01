using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Locadão.Infrastructure.configs;
using Locadão.Application.Services;
using Locadão.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adicionar configuração do DbContext
builder.Services.AddDbContext<LocadaoContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("LocadaoDatabase")));

// Adicionar configuração do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Locadão API", Version = "v1" });
});

// Adicionar serviços do seu domínio
// Exemplo:
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// Adicionar controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configurar middlewares

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // Ativar Swagger apenas em desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locadão API V1"));
}

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
