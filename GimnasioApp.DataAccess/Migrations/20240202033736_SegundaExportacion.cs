using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GimnasioApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SegundaExportacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrecioCompra = table.Column<float>(type: "real", nullable: false),
                    PrecioVenta = table.Column<float>(type: "real", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    UrlImagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroDocumento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_TipoDocumento_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentaDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    TotalDetalle = table.Column<float>(type: "real", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentaDetalle_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentaDetalle_Venta_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Descripcion", "Estado", "FechaCreacion" },
                values: new object[,]
                {
                    { 1, "Aminoacidos", true, new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5228) },
                    { 2, "Proteinas", true, new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5244) },
                    { 3, "Quemadores", true, new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5245) },
                    { 4, "Energia", true, new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5246) },
                    { 5, "Snack", true, new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5247) },
                    { 6, "Accesorios", true, new DateTime(2024, 2, 1, 22, 37, 35, 904, DateTimeKind.Local).AddTicks(5249) }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Descripcion", "Estado", "FechaCreacion" },
                values: new object[,]
                {
                    { 1, "Muscletech", true, new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8851) },
                    { 2, "Lab Nutrition", true, new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8857) },
                    { 3, "One", true, new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8858) },
                    { 4, "Universe", true, new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8859) },
                    { 5, "Novo", true, new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8860) },
                    { 6, "Cellucor", true, new DateTime(2024, 2, 1, 22, 37, 35, 905, DateTimeKind.Local).AddTicks(8862) }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumento",
                columns: new[] { "Id", "Descripcion", "Estado", "FechaCreacion" },
                values: new object[,]
                {
                    { 1, "Boleta", true, new DateTime(2024, 2, 1, 22, 37, 35, 910, DateTimeKind.Local).AddTicks(2659) },
                    { 2, "Ticket", true, new DateTime(2024, 2, 1, 22, 37, 35, 910, DateTimeKind.Local).AddTicks(2668) },
                    { 3, "Factura", true, new DateTime(2024, 2, 1, 22, 37, 35, 910, DateTimeKind.Local).AddTicks(2669) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_MarcaId",
                table: "Producto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_ClienteId",
                table: "Venta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_TipoDocumentoId",
                table: "Venta",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalle_ProductoId",
                table: "VentaDetalle",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalle_VentaId",
                table: "VentaDetalle",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaDetalle");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "TipoDocumento");
        }
    }
}
