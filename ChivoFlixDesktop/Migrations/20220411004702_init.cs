using Microsoft.EntityFrameworkCore.Migrations;

namespace ChivoFlixDesktop.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GENEROS",
                columns: table => new
                {
                    idGeneros = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GENEROS__525F69B8029B802E", x => x.idGeneros);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id_roles = table.Column<int>(nullable: false),
                    rol = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roles__C73330E7BED09827", x => x.id_roles);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id_usuarios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usuarios__854B73B303E44E5D", x => x.id_usuarios);
                });

            migrationBuilder.CreateTable(
                name: "PELICULAS",
                columns: table => new
                {
                    idPeliculas = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK__PELICULA__71DB443F076FB354", x => x.idPeliculas);
                    table.ForeignKey(
                        name: "fk_Peliculas_Generos",
                        column: x => x.idGeneros,
                        principalTable: "GENEROS",
                        principalColumn: "idGeneros",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PLANES",
                columns: table => new
                {
                    idPlanes = table.Column<int>(nullable: false),
                    planes = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    idUsuarios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PLANES__31C4681E6A8EB528", x => x.idPlanes);
                    table.ForeignKey(
                        name: "fk_Planes_Usuarios",
                        column: x => x.idUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "id_usuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TARJETAS",
                columns: table => new
                {
                    idTarjetas = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroTarjeta = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    fechaVencimiento = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    CVV = table.Column<int>(nullable: false),
                    idUsuarios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TARJETAS__B6CCF1D9550EEA0A", x => x.idTarjetas);
                    table.ForeignKey(
                        name: "fk_Tarjetas_Usuarios",
                        column: x => x.idUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "id_usuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LISTADO",
                columns: table => new
                {
                    idListado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPeliculas = table.Column<int>(nullable: false),
                    idUsuarios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LISTADO__EEA3B4655F537D8E", x => x.idListado);
                    table.ForeignKey(
                        name: "fk_Listado_Peliculas",
                        column: x => x.idPeliculas,
                        principalTable: "PELICULAS",
                        principalColumn: "idPeliculas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Listado_Usuarios",
                        column: x => x.idUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "id_usuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LISTADO_idPeliculas",
                table: "LISTADO",
                column: "idPeliculas");

            migrationBuilder.CreateIndex(
                name: "IX_LISTADO_idUsuarios",
                table: "LISTADO",
                column: "idUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_PELICULAS_idGeneros",
                table: "PELICULAS",
                column: "idGeneros");

            migrationBuilder.CreateIndex(
                name: "IX_PLANES_idUsuarios",
                table: "PLANES",
                column: "idUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_TARJETAS_idUsuarios",
                table: "TARJETAS",
                column: "idUsuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LISTADO");

            migrationBuilder.DropTable(
                name: "PLANES");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "TARJETAS");

            migrationBuilder.DropTable(
                name: "PELICULAS");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "GENEROS");
        }
    }
}
