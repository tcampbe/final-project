﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class AddStudentsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    English = table.Column<string>(nullable: true),
                    Math = table.Column<string>(nullable: true),
                    Science = table.Column<string>(nullable: true),
                    SocialStudies = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "English", "Math", "Name", "Science", "SocialStudies" },
                values: new object[] { 1, "Old Fashioned Education Fairy tales", "Old Fashioned Education Arithmetic", "Jon S", "Old Fashioned Education Science & Nature", "Old Fashioned Education Geography " });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "English", "Math", "Name", "Science", "SocialStudies" },
                values: new object[] { 2, "Khan Academy Grammar", "Alison Core Math Skills", "Bobby M", "Khan Academy Biology", "Hilsdale College Free Courses" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "English", "Math", "Name", "Science", "SocialStudies" },
                values: new object[] { 3, "Coursera English Composition I", "Udemy Geometry", "Sarah B", "Academic Earth Chemistry", "edX Introduction to American Government" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
