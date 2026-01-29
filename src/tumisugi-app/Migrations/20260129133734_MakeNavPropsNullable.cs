using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TumisugiApp.Migrations
{
    /// <inheritdoc />
    public partial class MakeNavPropsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TumiHistories_TumiManagements_TumiManageId",
                table: "TumiHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TumiManagements_GetGenreDetails_GenreDetailCode",
                table: "TumiManagements");

            migrationBuilder.AlterColumn<int>(
                name: "GenreDetailCode",
                table: "TumiManagements",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "TumiManageId",
                table: "TumiHistories",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "GetGenreMajors",
                columns: new[] { "Code", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Game", "2026-01-28 00:00:00" },
                    { 2, "Anime", "2026-01-28 00:00:00" },
                    { 3, "Book", "2026-01-28 00:00:00" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TumiHistories_TumiManagements_TumiManageId",
                table: "TumiHistories",
                column: "TumiManageId",
                principalTable: "TumiManagements",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TumiManagements_GetGenreDetails_GenreDetailCode",
                table: "TumiManagements",
                column: "GenreDetailCode",
                principalTable: "GetGenreDetails",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TumiHistories_TumiManagements_TumiManageId",
                table: "TumiHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TumiManagements_GetGenreDetails_GenreDetailCode",
                table: "TumiManagements");

            migrationBuilder.DeleteData(
                table: "GetGenreMajors",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GetGenreMajors",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GetGenreMajors",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "GenreDetailCode",
                table: "TumiManagements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TumiManageId",
                table: "TumiHistories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TumiHistories_TumiManagements_TumiManageId",
                table: "TumiHistories",
                column: "TumiManageId",
                principalTable: "TumiManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TumiManagements_GetGenreDetails_GenreDetailCode",
                table: "TumiManagements",
                column: "GenreDetailCode",
                principalTable: "GetGenreDetails",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
