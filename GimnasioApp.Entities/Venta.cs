using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Entities
{
    public class Venta : EntityBase
    {
        public string NroDocumento { get; set; } = default!;
        public float Total { get; set; }

        public Cliente Cliente { get; set; }= default!;
        public int ClienteId { get; set; }

        public TipoDocumento TipoDocumento { get; set; }= default!;
        public int TipoDocumentoId { get; set; }
    }
}
