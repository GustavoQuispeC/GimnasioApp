using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Entities
{
    public class Categoria:EntityBase
    {
        public string Descripcion { get; set; } = default!;
    }
}
