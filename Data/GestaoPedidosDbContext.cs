using GestaoPedidos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoPedidos.Api.Data;

public class GestaoPedidosDbContext : DbContext
{
    public GestaoPedidosDbContext(DbContextOptions<GestaoPedidosDbContext> options)
        : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>()
            .Property(p => p.Preco)
            .HasPrecision(18, 2);
    }
}