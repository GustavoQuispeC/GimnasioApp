using GimnasioApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.DataAccess.Configurations
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.Property(p => p.Descripcion)
                .HasMaxLength(100);
            var lista = new List<Marca>
            {
                new() {Id = 1,Descripcion="Muscletech"},
                new() {Id = 2,Descripcion="Lab Nutrition"},
                new() {Id = 3,Descripcion="One"},
                new() {Id = 4,Descripcion="Universe"},
                new() {Id = 5,Descripcion="Novo"},
                new() {Id = 6,Descripcion="Cellucor"},
                
            };
            builder.HasData(lista);
        }
    }
}
