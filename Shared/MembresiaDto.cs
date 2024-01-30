using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Shared
{
    public class MembresiaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = default!;
        public float PrecioMembresia { get; set; }
        public string Observacion { get; set; } = default!;
        
    }
}
