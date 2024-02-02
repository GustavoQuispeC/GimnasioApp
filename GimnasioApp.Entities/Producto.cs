using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Entities
{
    public class Producto:EntityBase
    {
        public string Nombre { get; set; } = default!;
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string? UrlImagen { get; set; }

        public Categoria Categoria { get; set; } = default!;
        public int CategoriaId { get; set; }

        public Marca Marca { get; set; } = default!;
        public int MarcaId { get; set; }

    }
}
