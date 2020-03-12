using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class DropStudentAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    English = table.Column<string>(type: "TEXT", nullable: true),
                    Math = table.Column<string>(type: "TEXT", nullable: true),
                    Science = table.Column<string>(type: "TEXT", nullable: true),
                    SocialStudies = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Name", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { "Jon S", "Old Fashioned Education Fairy tales", "Old Fashioned Education Arithmetic", "Old Fashioned Education Science & Nature", "Old Fashioned Education Geography " });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Name", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { "Bobby M", "Khan Academy Grammar", "Alison Core Math Skills", "Khan Academy Biology", "Hilsdale College Free Courses" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Name", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { "Sarah B", "Coursera English Composition I", "Udemy Geometry", "Academic Earth Chemistry", "edX Introduction to American Government" });
        }
    }
}
