using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class cursosdisciplinascursosDisciplinas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CursosDisciplinas",
                columns: table => new
                {
                    CursoID = table.Column<int>(type: "int", nullable: false),
                    DisciplinaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosDisciplinas", x => new { x.CursoID, x.DisciplinaID });
                    table.ForeignKey(
                        name: "FK_CursosDisciplinas_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosDisciplinas_Disciplinas_DisciplinaID",
                        column: x => x.DisciplinaID,
                        principalTable: "Disciplinas",
                        principalColumn: "DisciplinaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursosDisciplinas_DisciplinaID",
                table: "CursosDisciplinas",
                column: "DisciplinaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursosDisciplinas");
        }
    }
}
