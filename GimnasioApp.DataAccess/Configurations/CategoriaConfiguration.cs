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
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(p => p.Descripcion)
               .HasMaxLength(100);
            var lista = new List<Categoria>
            {
                new () { Id =1,Descripcion ="Aminoacidos"},
                new () { Id =2,Descripcion ="Proteinas"},
                new () { Id =3,Descripcion ="Quemadores"},
                new () { Id =4,Descripcion ="Energia"},
                new () { Id =5,Descripcion ="Snack"},
                new () { Id =6,Descripcion ="Accesorios"}
            };
            builder.HasData(lista);
        }
    }
}
