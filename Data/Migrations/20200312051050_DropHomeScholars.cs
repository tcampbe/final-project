using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class DropHomeScholars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeScholars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeScholars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    English = table.Column<string>(type: "TEXT", nullable: true),
                    Math = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Science = table.Column<string>(type: "TEXT", nullable: true),
                    SocialStudies = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeScholars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HomeScholars",
                columns: new[] { "Id", "English", "Math", "Name", "Science", "SocialStudies" },
                values: new object[] { 1, "Old Fashioned Education Fairy tales", "Old Fashioned Education Arithmetic", "Jon Smith", "Old Fashioned Education Science & Nature", "Old Fashioned Education Geography " });

            migrationBuilder.InsertData(
                table: "HomeScholars",
                columns: new[] { "Id", "English", "Math", "Name", "Science", "SocialStudies" },
                values: new object[] { 2, "Khan Academy Grammar", "Alison Core Math Skills", "Bobby Miller", "Khan Academy Biology", "Hilsdale College Free Courses" });

            migrationBuilder.InsertData(
                table: "HomeScholars",
                columns: new[] { "Id", "English", "Math", "Name", "Science", "SocialStudies" },
                values: new object[] { 3, "Coursera English Composition I", "Udemy Geometry", "Sarah Brooks", "Academic Earth Chemistry", "edX Introduction to American Government" });
        }
    }
}
