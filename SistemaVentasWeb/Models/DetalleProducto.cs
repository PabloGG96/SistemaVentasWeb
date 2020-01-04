using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasWeb.Models
{
    public class DetalleProducto
    {
        public int ID { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }

        public int ProductoID { get; set; }

        public Producto Producto { get; set; }


    }
}
