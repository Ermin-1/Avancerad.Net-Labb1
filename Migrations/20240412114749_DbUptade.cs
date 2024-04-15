using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerad.Net_Labb1.Migrations
{
    /// <inheritdoc />
    public partial class DbUptade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ämnen",
                keyColumn: "ÄmneId",
                keyValue: 3,
                column: "ÄmneNamn",
                value: "Programmering1");

            migrationBuilder.UpdateData(
                table: "Ämnen",
                keyColumn: "ÄmneId",
                keyValue: 4,
                column: "ÄmneNamn",
                value: "Programmering2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ämnen",
                keyColumn: "ÄmneId",
                keyValue: 3,
                column: "ÄmneNamn",
                value: "Phyton");

            migrationBuilder.UpdateData(
                table: "Ämnen",
                keyColumn: "ÄmneId",
                keyValue: 4,
                column: "ÄmneNamn",
                value: "GoLang");
        }
    }
}
