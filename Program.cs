using GestaoPedidos.Api.Data;
using GestaoPedidos.Api.Repositories;
using Microsoft.EntityFrameworkCore;
using GestaoPedidos.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "GestaoPedidos.Api",
        Version = "v1"
    });
});

builder.Services.AddDbContext<GestaoPedidosDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("GestaoPedidos")));

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddScoped<IProdutoService, ProdutoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
            "/swagger/v1/swagger.json",
            "GestaoPedidos.Api v1");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();