using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerad.Net_Labb1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseReidar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lärare",
                keyColumn: "LärarId",
                keyValue: 4,
                column: "LärarNamn",
                value: "Reidar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lärare",
                keyColumn: "LärarId",
                keyValue: 4,
                column: "LärarNamn",
                value: "Ali");
        }
    }
}
