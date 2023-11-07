using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apiuniversidade.Migrations
{
    /// <inheritdoc />
    public partial class updatingModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Curso_Cursoid",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplina_Curso_Cursoid",
                table: "Disciplina");

            migrationBuilder.RenameColumn(
                name: "semestre",
                table: "Disciplina",
                newName: "Semestre");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Disciplina",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Cursoid",
                table: "Disciplina",
                newName: "CursoId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Disciplina",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplina_Cursoid",
                table: "Disciplina",
                newName: "IX_Disciplina_CursoId");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Curso",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "duracao",
                table: "Curso",
                newName: "Duracao");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Curso",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Curso",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Cursoid",
                table: "Aluno",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_Cursoid",
                table: "Aluno",
                newName: "IX_Aluno_CursoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Aluno",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Aluno",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Curso_CursoId",
                table: "Aluno",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplina_Curso_CursoId",
                table: "Disciplina",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Curso_CursoId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplina_Curso_CursoId",
                table: "Disciplina");

            migrationBuilder.RenameColumn(
                name: "Semestre",
                table: "Disciplina",
                newName: "semestre");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Disciplina",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Disciplina",
                newName: "Cursoid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Disciplina",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Disciplina_CursoId",
                table: "Disciplina",
                newName: "IX_Disciplina_Cursoid");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Curso",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Duracao",
                table: "Curso",
                newName: "duracao");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Curso",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Curso",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Aluno",
                newName: "Cursoid");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_CursoId",
                table: "Aluno",
                newName: "IX_Aluno_Cursoid");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Aluno",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Aluno",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Curso_Cursoid",
                table: "Aluno",
                column: "Cursoid",
                principalTable: "Curso",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplina_Curso_Cursoid",
                table: "Disciplina",
                column: "Cursoid",
                principalTable: "Curso",
                principalColumn: "id");
        }
    }
}
