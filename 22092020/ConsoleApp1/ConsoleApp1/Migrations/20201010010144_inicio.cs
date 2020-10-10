using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTarea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(maxLength: 50, nullable: true),
                    clave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    vencimiento = table.Column<string>(nullable: true),
                    estimacion = table.Column<int>(nullable: false),
                    responsableId = table.Column<int>(nullable: true),
                    estado = table.Column<bool>(nullable: false),
                    tipoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_responsableId",
                        column: x => x.responsableId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarea_TipoTarea_tipoId",
                        column: x => x.tipoId,
                        principalTable: "TipoTarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<string>(nullable: true),
                    tiempo = table.Column<string>(nullable: true),
                    tareasId = table.Column<int>(nullable: true),
                    recursoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_recursoId",
                        column: x => x.recursoId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_tareasId",
                        column: x => x.tareasId,
                        principalTable: "Tarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_recursoId",
                table: "Detalle",
                column: "recursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_tareasId",
                table: "Detalle",
                column: "tareasId");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_usuarioId",
                table: "Recurso",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_responsableId",
                table: "Tarea",
                column: "responsableId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_tipoId",
                table: "Tarea",
                column: "tipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "TipoTarea");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
