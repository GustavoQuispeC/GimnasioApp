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
    public class VentaDetalleConfiguration : IEntityTypeConfiguration<VentaDetalle>
    {
        public void Configure(EntityTypeBuilder<VentaDetalle> builder)
        {
            builder.Property(p => p.Cantidad);
            builder.Property(p => p.Precio);
            builder.Property(p => p.TotalDetalle);

        }
    }
}
