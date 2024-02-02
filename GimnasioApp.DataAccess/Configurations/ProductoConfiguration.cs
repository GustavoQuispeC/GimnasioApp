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
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(p => p.Nombre)
                .HasMaxLength(100);
            builder.Property(p => p.PrecioCompra);
            builder.Property(p => p.PrecioVenta);
            builder.Property(P => P.Stock);
            builder.Property(p => p.UrlImagen);
        }
    }
}
