using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Entities
{
    public class TipoDocumento:EntityBase
    {
        public string Descripcion { get; set; } = default!;
    }
}
