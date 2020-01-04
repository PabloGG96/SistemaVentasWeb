using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace SistemaVentasWeb.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        
        public DetalleProducto Detalle { get; set; }
    }
}
