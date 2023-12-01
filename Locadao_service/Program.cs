using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Locad�o.Infrastructure.configs;
using Locad�o.Application.Services;
using Locad�o.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adicionar configura��o do DbContext
builder.Services.AddDbContext<LocadaoContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("LocadaoDatabase")));

// Adicionar configura��o do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Locad�o API", Version = "v1" });
});

// Adicionar servi�os do seu dom�nio
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
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locad�o API V1"));
}

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
