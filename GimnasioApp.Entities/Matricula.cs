using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Entities
{
    public class Matricula:EntityBase
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get;set; }
        public float PrecioTotal { get; set; }

        public Cliente Cliente { get; set; } = default!;
        public int ClienteId { get; set; }

        public Membresia Membresia { get; set; }= default!;
        public int MembresiaId { get;set; }
    }
}
