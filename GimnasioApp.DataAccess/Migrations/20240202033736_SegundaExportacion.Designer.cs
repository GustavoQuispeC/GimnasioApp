﻿// <auto-generated />
using System;
using GimnasioApp.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GimnasioApp.DataAccess.Migrations
{
    [DbContext(typeof(GimnasioAppDbContext))]
    [Migration("20240202033736_SegundaExportacion")]
    partial class SegundaExportacion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GimnasioApp.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Aminoacidos",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5228)
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Proteinas",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5244)
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Quemadores",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5245)
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Energia",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5246)
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Snack",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5247)
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Accesorios",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5249)
                        });
                });

            modelBuilder.Entity("GimnasioApp.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoM")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ApellidoP")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TelefonoEmergencia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("GimnasioApp.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Marca");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Muscletech",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8851)
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Lab Nutrition",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8857)
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "One",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8858)
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Universe",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8859)
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Novo",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8860)
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Cellucor",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8862)
                        });
                });

            modelBuilder.Entity("GimnasioApp.Entities.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaTermino")
                        .HasColumnType("datetime2");

                    b.Property<int>("MembresiaId")
                        .HasColumnType("int");

                    b.Property<float>("PrecioTotal")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MembresiaId");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("GimnasioApp.Entities.Membresia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("PrecioMembresia")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Membresia");
                });

            modelBuilder.Entity("GimnasioApp.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("real");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("GimnasioApp.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Boleta",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 910, DateTimeKind.Local).AddTicks(2659)
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Ticket",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 910, DateTimeKind.Local).AddTicks(2668)
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Factura",
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 1, 22, 37, 35, 910, DateTimeKind.Local).AddTicks(2669)
                        });
                });

            modelBuilder.Entity("GimnasioApp.Entities.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NroDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("GimnasioApp.Entities.VentaDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<float>("TotalDetalle")
                        .HasColumnType("real");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentaDetalle");
                });

            modelBuilder.Entity("GimnasioApp.Entities.Matricula", b =>
                {
                    b.HasOne("GimnasioApp.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GimnasioApp.Entities.Membresia", "Membresia")
                        .WithMany()
                        .HasForeignKey("MembresiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Membresia");
                });

            modelBuilder.Entity("GimnasioApp.Entities.Producto", b =>
                {
                    b.HasOne("GimnasioApp.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GimnasioApp.Entities.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("GimnasioApp.Entities.Venta", b =>
                {
                    b.HasOne("GimnasioApp.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GimnasioApp.Entities.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("GimnasioApp.Entities.VentaDetalle", b =>
                {
                    b.HasOne("GimnasioApp.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GimnasioApp.Entities.Venta", "venta")
                        .WithMany()
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("venta");
                });
#pragma warning restore 612, 618
        }
    }
}