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
    public class MembresiaConfiguration : IEntityTypeConfiguration<Membresia>
    {
        public void Configure(EntityTypeBuilder<Membresia> builder)
        {
            builder.Property(p=>p.Descripcion)
                .HasMaxLength(100);
            builder.Property(p => p.PrecioMembresia);
            builder.Property(p=>p.Observacion) 
                .HasMaxLength(200);

        }
    }
}
