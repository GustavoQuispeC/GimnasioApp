using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Shared
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = default!;
        public string ApellidoP { get; set; } = default!;
        public string ApellidoM { get; set; } = default!;
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; } = default!;
        public int DNI { get; set; }
        public string Direccion { get; set; } = default!;
        public string Correo { get; set; } = default!;
        public string Telefono { get; set; } = default!;
        public string TelefonoEmergencia { get; set; } = default!;
        public string EstadoCivil { get; set; } = default!;
        public DateTime FechaCreacion { get; set; }

    }
}
