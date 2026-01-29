using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TumisugiApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedAddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "TumiHistories",
                columns: new[] { "Id", "StatusCode", "TumiId", "TumiManageId", "UpdateAt" },
                values: new object[] { 1, 3, 1, null, "2026-01-28 00:00:00" });

            migrationBuilder.InsertData(
                table: "TumiManagements",
                columns: new[] { "Id", "GanreDetailCode", "GenreDetailCode", "GenreMajorCode", "Memo", "Name", "PlatformCode", "StatusCode", "UpdateAt" },
                values: new object[] { 1, 1, null, 1, "セイバールートのみクリアしているが他ルートもやりたい...", "Fate/StayNight", 1, 3, "2026-01-28 00:00:00" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GetGenreDetails",
                keyColumn: "Code",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Code",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TumiHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TumiManagements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Code",
                keyValue: 3);
        }
    }
}
