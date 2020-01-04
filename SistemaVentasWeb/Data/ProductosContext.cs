using SistemaVentasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentasWeb.Data
{
    public class ProductosContext : DbContext
    {
        public ProductosContext(DbContextOptions<ProductosContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<DetalleProducto> DetalledeProductos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<DetalleProducto>().ToTable("DetalleDeProductos");
           
        }
    }
}