using SistemaVentasWeb.Models;
using System;
using System.Linq;


namespace SistemaVentasWeb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductosContext context)
        {
            context.Database.EnsureCreated();

            // Look for any productos.
            if (context.Productos.Any())
            {
                return;   // DB has been seeded
            }

            var productos = new Producto[]
            {
            new Producto{Nombre = "Leche Serenisima x 1LT"},
            new Producto{Nombre = "Arroz de Kilo Ala"}

            };
            foreach (Producto s in productos)
            {
                context.Productos.Add(s);
            }
            context.SaveChanges();

            var detallesdeproducto = new DetalleProducto[]
            {
            new DetalleProducto{Stock=1000, Precio=30,Descripcion = "La más elegida de los argentinos.",ProductoID=1},
            new DetalleProducto{Stock=1000, Precio=(float)12.40,Descripcion = "Arroz de Kilo Ala que contiene 1000 gramos de arroz de la mejor calidad",ProductoID=2},
            };

            foreach (DetalleProducto d in detallesdeproducto)
            {
                context.DetalledeProductos.Add(d);
            }
            context.SaveChanges();

          
        }
    }
}