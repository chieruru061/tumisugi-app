using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TumisugiApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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

            migrationBuilder.InsertData(
                table: "GetGenreMajors",
                columns: new[] { "Code", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Game", "2026-01-28 00:00:00" },
                    { 2, "Anime", "2026-01-28 00:00:00" },
                    { 3, "Book", "2026-01-28 00:00:00" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Code", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "PC", "2026-01-28 00:00:00" },
                    { 2, "PlayStation", "2026-01-28 00:00:00" },
                    { 3, "Switch", "2026-01-28 00:00:00" },
                    { 4, "Mobile", "2026-01-28 00:00:00" },
                    { 5, "Web", "2026-01-28 00:00:00" },
                    { 6, "others", "2026-01-28 00:00:00" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Code", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "未購入", "2026-01-28 00:00:00" },
                    { 2, "未プレイ", "2026-01-28 00:00:00" },
                    { 3, "放置中", "2026-01-28 00:00:00" },
                    { 4, "プレイ中", "2026-01-28 00:00:00" },
                    { 5, "積み解消", "2026-01-28 00:00:00" }
                });

            migrationBuilder.InsertData(
                table: "GetGenreDetails",
                columns: new[] { "Code", "GenreMajorCode", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, "RPG", "2026-01-28 00:00:00" },
                    { 2, 1, "アクション", "2026-01-28 00:00:00" },
                    { 3, 1, "アドベンチャー", "2026-01-28 00:00:00" },
                    { 4, 1, "ストラテジ", "2026-01-28 00:00:00" },
                    { 5, 1, "レース", "2026-01-28 00:00:00" },
                    { 6, 1, "音ゲー", "2026-01-28 00:00:00" },
                    { 7, 1, "STG", "2026-01-28 00:00:00" },
                    { 8, 1, "カード", "2026-01-28 00:00:00" },
                    { 9, 1, "ギャルゲ", "2026-01-28 00:00:00" },
                    { 99, 1, "その他", "2026-01-28 00:00:00" }
                });

            migrationBuilder.InsertData(
                table: "TumiManagements",
                columns: new[] { "Id", "GenreDetailCode", "GenreMajorCode", "Memo", "Name", "PlatformCode", "StatusCode", "UpdateAt" },
                values: new object[] { 1, 1, 1, "セイバールートのみクリアしているが他ルートもやりたい...", "Fate/StayNight", 1, 3, "2026-01-28 00:00:00" });

            migrationBuilder.InsertData(
                table: "TumiHistories",
                columns: new[] { "Id", "StatusCode", "TumiManageId", "UpdateAt" },
                values: new object[] { 1, 3, 1, "2026-01-28 00:00:00" });

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
