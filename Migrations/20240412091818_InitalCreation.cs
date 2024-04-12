using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Avancerad.Net_Labb1.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klasser",
                columns: table => new
                {
                    KlassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlassNamn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klasser", x => x.KlassId);
                });

            migrationBuilder.CreateTable(
                name: "Lärare",
                columns: table => new
                {
                    LärarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LärarNamn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lärare", x => x.LärarId);
                });

            migrationBuilder.CreateTable(
                name: "Studenter",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNamn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenter", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Ämnen",
                columns: table => new
                {
                    ÄmneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ÄmneNamn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ämnen", x => x.ÄmneId);
                });

            migrationBuilder.CreateTable(
                name: "Kopplingstabeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LärarId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    KlassId = table.Column<int>(type: "int", nullable: false),
                    ÄmneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kopplingstabeller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kopplingstabeller_Klasser_KlassId",
                        column: x => x.KlassId,
                        principalTable: "Klasser",
                        principalColumn: "KlassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kopplingstabeller_Lärare_LärarId",
                        column: x => x.LärarId,
                        principalTable: "Lärare",
                        principalColumn: "LärarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kopplingstabeller_Studenter_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Studenter",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kopplingstabeller_Ämnen_ÄmneId",
                        column: x => x.ÄmneId,
                        principalTable: "Ämnen",
                        principalColumn: "ÄmneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Klasser",
                columns: new[] { "KlassId", "KlassNamn" },
                values: new object[,]
                {
                    { 1, "SUT23" },
                    { 2, "SUT22" }
                });

            migrationBuilder.InsertData(
                table: "Lärare",
                columns: new[] { "LärarId", "LärarNamn" },
                values: new object[,]
                {
                    { 1, "Anas" },
                    { 2, "Tobias" },
                    { 3, "Lennart" },
                    { 4, "Ali" }
                });

            migrationBuilder.InsertData(
                table: "Studenter",
                columns: new[] { "StudentId", "StudentNamn" },
                values: new object[,]
                {
                    { 1, "Ermin" },
                    { 2, "Oskar" },
                    { 3, "Ludde" },
                    { 4, "Johan" },
                    { 5, "Aska" },
                    { 6, "Simon" },
                    { 7, "Ali" },
                    { 8, "Mohamed" },
                    { 9, "Shahram" },
                    { 10, "Ortiz" },
                    { 11, "Markus" },
                    { 12, "Fredrik" }
                });

            migrationBuilder.InsertData(
                table: "Ämnen",
                columns: new[] { "ÄmneId", "ÄmneNamn" },
                values: new object[,]
                {
                    { 1, "Mattematik" },
                    { 2, "C#" },
                    { 3, "Phyton" },
                    { 4, "GoLang" }
                });

            migrationBuilder.InsertData(
                table: "Kopplingstabeller",
                columns: new[] { "Id", "KlassId", "LärarId", "StudentId", "ÄmneId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1 },
                    { 2, 1, 2, 2, 1 },
                    { 3, 1, 3, 3, 1 },
                    { 4, 1, 4, 4, 2 },
                    { 5, 1, 1, 5, 2 },
                    { 6, 1, 2, 6, 2 },
                    { 7, 2, 3, 7, 3 },
                    { 8, 2, 4, 8, 3 },
                    { 9, 2, 1, 9, 3 },
                    { 10, 2, 2, 10, 4 },
                    { 11, 2, 3, 11, 4 },
                    { 12, 2, 4, 12, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kopplingstabeller_KlassId",
                table: "Kopplingstabeller",
                column: "KlassId");

            migrationBuilder.CreateIndex(
                name: "IX_Kopplingstabeller_LärarId",
                table: "Kopplingstabeller",
                column: "LärarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kopplingstabeller_StudentId",
                table: "Kopplingstabeller",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Kopplingstabeller_ÄmneId",
                table: "Kopplingstabeller",
                column: "ÄmneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kopplingstabeller");

            migrationBuilder.DropTable(
                name: "Klasser");

            migrationBuilder.DropTable(
                name: "Lärare");

            migrationBuilder.DropTable(
                name: "Studenter");

            migrationBuilder.DropTable(
                name: "Ämnen");
        }
    }
}
