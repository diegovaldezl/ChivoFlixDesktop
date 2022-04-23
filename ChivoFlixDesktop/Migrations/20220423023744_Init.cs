using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChivoFlixDesktop.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "duracionPlanes",
                columns: table => new
                {
                    idDuracionPlanes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__duracion__812FA85D4DDDD2A5", x => x.idDuracionPlanes);
                });

            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    idGeneros = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__generos__525F69B817391CE1", x => x.idGeneros);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    idRol = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rol = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roles__3C872F76AB588757", x => x.idRol);
                });

            migrationBuilder.CreateTable(
                name: "peliculas",
                columns: table => new
                {
                    idPeliculas = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    anioEstreno = table.Column<int>(nullable: false),
                    categoriaEdad = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    calidad = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    director = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    banner = table.Column<string>(unicode: false, nullable: false),
                    idGeneros = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pelicula__71DB443F16B1CBF9", x => x.idPeliculas);
                    table.ForeignKey(
                        name: "fk_Peliculas_Generos",
                        column: x => x.idGeneros,
                        principalTable: "generos",
                        principalColumn: "idGeneros",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    idUsuarios = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    perfiles = table.Column<int>(nullable: true),
                    imagen = table.Column<string>(unicode: false, nullable: true),
                    idRol = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usuarios__3940559A7C6EFA46", x => x.idUsuarios);
                    table.ForeignKey(
                        name: "fk_Usuarios_Roles",
                        column: x => x.idRol,
                        principalTable: "roles",
                        principalColumn: "idRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "listados",
                columns: table => new
                {
                    idListado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPeliculas = table.Column<int>(nullable: false),
                    idUsuarios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__listados__EEA3B4650814573D", x => x.idListado);
                    table.ForeignKey(
                        name: "fk_Listado_Peliculas",
                        column: x => x.idPeliculas,
                        principalTable: "peliculas",
                        principalColumn: "idPeliculas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Listado_Usuarios",
                        column: x => x.idUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "idUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "planes",
                columns: table => new
                {
                    idPlanes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plann = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    precioPlan = table.Column<double>(nullable: false),
                    idDuracionPlanes = table.Column<int>(nullable: false),
                    idUsuarios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__planes__31C4681E538E7E4D", x => x.idPlanes);
                    table.ForeignKey(
                        name: "fk_Planes_DuracionP",
                        column: x => x.idDuracionPlanes,
                        principalTable: "duracionPlanes",
                        principalColumn: "idDuracionPlanes",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Planes_Usuarios",
                        column: x => x.idUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "idUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "facturaciones",
                columns: table => new
                {
                    idFacturaciones = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuarios = table.Column<int>(nullable: false),
                    idPlanes = table.Column<int>(nullable: false),
                    plann = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    fechaAdquirido = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipo = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    precio = table.Column<double>(nullable: false),
                    total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__facturac__85C535F2A8D79B67", x => x.idFacturaciones);
                    table.ForeignKey(
                        name: "fk_Facuraciones_Planes",
                        column: x => x.idPlanes,
                        principalTable: "planes",
                        principalColumn: "idPlanes",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Facturaciones_Usuarios",
                        column: x => x.idUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "idUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_facturaciones_idPlanes",
                table: "facturaciones",
                column: "idPlanes");

            migrationBuilder.CreateIndex(
                name: "IX_facturaciones_idUsuarios",
                table: "facturaciones",
                column: "idUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_listados_idPeliculas",
                table: "listados",
                column: "idPeliculas");

            migrationBuilder.CreateIndex(
                name: "IX_listados_idUsuarios",
                table: "listados",
                column: "idUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_peliculas_idGeneros",
                table: "peliculas",
                column: "idGeneros");

            migrationBuilder.CreateIndex(
                name: "IX_planes_idDuracionPlanes",
                table: "planes",
                column: "idDuracionPlanes");

            migrationBuilder.CreateIndex(
                name: "IX_planes_idUsuarios",
                table: "planes",
                column: "idUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_idRol",
                table: "usuarios",
                column: "idRol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "facturaciones");

            migrationBuilder.DropTable(
                name: "listados");

            migrationBuilder.DropTable(
                name: "planes");

            migrationBuilder.DropTable(
                name: "peliculas");

            migrationBuilder.DropTable(
                name: "duracionPlanes");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "generos");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
