using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Entities
{
    public class VentaDetalle:EntityBase
    {
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float TotalDetalle { get; set; }

        public Producto Producto { get; set; } = default!;
        public int ProductoId { get; set; }

        public Venta venta { get; set; }=default!;
        public int VentaId { get; set; }

    }
}
