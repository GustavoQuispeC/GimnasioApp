using GimnasioApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.DataAccess.Configurations
{
    public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.Property(P => P.Descripcion)
                .HasMaxLength(100);
            var lista = new List<TipoDocumento>
            {
                new() {Id = 1,Descripcion="Boleta"},
                new() {Id = 2,Descripcion="Ticket"},
                new() {Id = 3,Descripcion="Factura"}

            };
            builder.HasData(lista);
        }
    }
}
