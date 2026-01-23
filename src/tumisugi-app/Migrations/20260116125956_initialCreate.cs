using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TumisugiApp.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetGenreMajors",
                columns: table => new
                {
                    Code = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetGenreMajors", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Code = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Code = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "GetGenreDetails",
                columns: table => new
                {
                    Code = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreMajorCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UpdateAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetGenreDetails", x => x.Code);
                    table.ForeignKey(
                        name: "FK_GetGenreDetails_GetGenreMajors_GenreMajorCode",
                        column: x => x.GenreMajorCode,
                        principalTable: "GetGenreMajors",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TumiManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    GenreMajorCode = table.Column<int>(type: "INTEGER", nullable: false),
                    GanreDetailCode = table.Column<int>(type: "INTEGER", nullable: false),
                    GenreDetailCode = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusCode = table.Column<int>(type: "INTEGER", nullable: false),
                    PlatformCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Memo = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumiManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TumiManagements_GetGenreDetails_GenreDetailCode",
                        column: x => x.GenreDetailCode,
                        principalTable: "GetGenreDetails",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TumiManagements_GetGenreMajors_GenreMajorCode",
                        column: x => x.GenreMajorCode,
                        principalTable: "GetGenreMajors",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TumiManagements_Platforms_PlatformCode",
                        column: x => x.PlatformCode,
                        principalTable: "Platforms",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TumiManagements_Statuses_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "Statuses",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TumiHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TumiId = table.Column<int>(type: "INTEGER", nullable: false),
                    TumiManageId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusCode = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdateAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumiHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TumiHistories_Statuses_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "Statuses",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TumiHistories_TumiManagements_TumiManageId",
                        column: x => x.TumiManageId,
                        principalTable: "TumiManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GetGenreDetails_GenreMajorCode",
                table: "GetGenreDetails",
                column: "GenreMajorCode");

            migrationBuilder.CreateIndex(
                name: "IX_TumiHistories_StatusCode",
                table: "TumiHistories",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_TumiHistories_TumiManageId",
                table: "TumiHistories",
                column: "TumiManageId");

            migrationBuilder.CreateIndex(
                name: "IX_TumiManagements_GenreDetailCode",
                table: "TumiManagements",
                column: "GenreDetailCode");

            migrationBuilder.CreateIndex(
                name: "IX_TumiManagements_GenreMajorCode",
                table: "TumiManagements",
                column: "GenreMajorCode");

            migrationBuilder.CreateIndex(
                name: "IX_TumiManagements_PlatformCode",
                table: "TumiManagements",
                column: "PlatformCode");

            migrationBuilder.CreateIndex(
                name: "IX_TumiManagements_StatusCode",
                table: "TumiManagements",
                column: "StatusCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TumiHistories");

            migrationBuilder.DropTable(
                name: "TumiManagements");

            migrationBuilder.DropTable(
                name: "GetGenreDetails");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "GetGenreMajors");
        }
    }
}
