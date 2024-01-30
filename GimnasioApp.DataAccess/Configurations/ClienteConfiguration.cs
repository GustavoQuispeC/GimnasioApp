using GimnasioApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace GimnasioApp.DataAccess.Configurations
{
    public class ClienteConfiguration:IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(p => p.Nombres)
                .HasMaxLength(100);
            builder.Property(p=>p.ApellidoP)
                .HasMaxLength(100);
            builder.Property (p=>p.ApellidoM)
                .HasMaxLength(100);
            builder.Property(p => p.FechaNacimiento);
               //.HasColumnType("DATE");
            builder.Property(p=>p.Genero)
                .HasMaxLength (50);
            builder.Property(p => p.DNI);
            builder.Property(p => p.Direccion)
                .HasMaxLength(300);
            builder.Property(p=>p.Correo)
                .IsUnicode(false);
            builder.Property(p=>p.Telefono)
                .HasMaxLength(20);
            builder.Property(p => p.TelefonoEmergencia)
                .HasMaxLength(20);
            builder.Property(p=>p.EstadoCivil)
                .HasMaxLength(20);

        }
    }
}
