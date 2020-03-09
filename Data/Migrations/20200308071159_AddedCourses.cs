using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class AddedCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Resource = table.Column<bool>(nullable: false),
                    PreSchool = table.Column<bool>(nullable: false),
                    Elementary = table.Column<bool>(nullable: false),
                    MiddleSchool = table.Column<bool>(nullable: false),
                    HighSchool = table.Column<bool>(nullable: false),
                    HigherEducation = table.Column<bool>(nullable: false),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 25, " all ", false, true, false, false, " All in One High School ", false, false, " online ", " https://allinonehighschool.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 62, " science ", false, true, false, false, " Coursera Plants Part I ", false, false, " online ", " https://www.coursera.org/learn/plantknows " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 61, " science ", false, true, false, false, " Khan Academy AP Physics 2 ", false, false, " online ", " https://www.khanacademy.org/science/physics/ap-physics-2 " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 58, " science ", false, true, false, true, " Khan Academy Biology ", false, false, " online ", " https://www.khanacademy.org/science/biology " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 41, " math ", false, false, false, false, " Math-U-See ", false, true, " books ", " https://www.mathusee.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 40, " math ", false, false, false, false, " Miquon ", false, true, " books ", " https://miquonmath.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 39, " math ", false, false, false, false, " Apologia ", false, true, " books ", " https://www.apologia.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 53, " science ", false, true, true, true, " Learn HTML(5) ", false, false, " app ", " https://www.microsoft.com/en-us/p/learn-html-5/9nblggh31wfj?activetab=pivot:overviewtab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 43, " math ", true, false, false, false, " Khan Academy Early Math ", true, false, " online ", " https://www.khanacademy.org/math/early-math " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 48, " math ", false, true, true, false, " Udemy Geometry ", false, false, " online ", " https://www.udemy.com/topic/geometry/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 47, " math ", false, true, true, false, " Coursera Intro to Calculus ", false, false, " online ", " https://www.coursera.org/learn/introduction-to-calculus " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 46, " math ", false, true, true, false, " edTrue Math Essentials ", false, false, " online ", " https://www.edTrue.org/course/maths-essentials " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 44, " math ", false, true, true, true, " Alison Core Math Skills ", false, false, " online ", " https://alison.com/courses/core-maths-skills " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 49, " math ", false, true, false, false, " Khan Academy High School Math ", false, false, " online ", " https://www.khanacademy.org/math/high-school-math " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 45, " math ", false, true, false, true, " Khan Academy PreAlgebra ", false, false, " online ", " https://www.khanacademy.org/math/pre-algebra " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 42, " math ", true, false, false, true, " Old Fashioned Education Arithmetic ", true, false, " online ", " http://oldfashionededucation.com/arithmetic_math.htm " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 28, " english ", false, false, false, false, " Ambleside ", false, true, " link ", " https://www.amblesideonline.org/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 55, " science ", false, true, true, true, " C++ Programming by Wagmob ", false, false, " app ", " https://www.microsoft.com/en-us/p/c-programming-by-wagmob/9wzdncrdn96h?activetab=pivot:overviewtab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 57, " science ", false, true, true, true, " Udemy Nutrition ", false, false, " online ", " https://www.udemy.com/topic/nutrition/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 65, " social studies ", true, false, false, true, " Old Fashioned Education Geography  ", true, false, " online ", " http://oldfashionededucation.com/geography.htm " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 66, " social studies ", true, true, false, true, " Khan Academy US History ", false, false, " online ", " https://www.khanacademy.org/humanities/us-history " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 71, " social studies ", false, true, true, false, " Udemy Psychology ", false, false, " online ", " https://www.udemy.com/topic/social-psychology/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 70, " social studies ", false, true, true, false, " edTrue Introduction to American Government ", false, false, " online ", " https://www.edTrue.org/Trueseries/harvardTrue-us-government " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 68, " social studies ", false, true, true, true, " Hilsdale College Free Courses ", false, false, " online ", " https://www.hillsdale.edu/educational-outreach/free-online-courses/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 67, " social studies ", false, true, true, true, " Coursera Economics of Money  ", false, false, " online ", " https://www.coursera.org/learn/money-banking " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 56, " science ", false, true, true, true, " Chemistry by WAGmob ", false, false, " app ", " https://www.microsoft.com/en-us/p/chemistry-by-wagmob/9wzdncrdn317?activetab=pivot:overviewtab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 72, " social studies ", false, true, false, false, " Khan Academy Ap World History ", false, false, " online ", " https://www.khanacademy.org/humanities/ap-world-history " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 51, " science ", true, false, false, false, " National Geographic Kids ", true, true, " online ", " https://kids.nationalgeographic.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 50, " science ", false, false, false, false, " C O D E ", false, true, " link ", " https://code.org/learn " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 52, " science ", false, false, false, false, " Apologia ", false, true, " books ", " https://www.apologia.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 54, " science ", true, false, false, true, " Khan Academy Health & Medicine ", false, false, " online ", " https://www.khanacademy.org/science/health-and-medicine " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 60, " science ", false, true, true, false, " Academic Earth Chemistry ", false, false, " online ", " https://academicearth.org/chemistry/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 59, " science ", false, true, true, false, " edTrue Applied Human Anatomy  ", false, false, " online ", " https://www.edTrue.org/course/applied-anatomy-of-the-locomotor-system " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 69, " social studies ", false, true, false, true, " Khan Academy US Government & Civics ", false, false, " online ", " https://www.khanacademy.org/humanities/us-government-and-civics " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 26, " english ", false, false, false, false, " MemRise ", false, true, " link ", " https://www.memrise.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 27, " english ", false, false, false, false, " Rosetta Stone ", false, true, " books ", " https://www.rosettastone.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 29, " english ", true, true, true, true, " Bible Study Tools ", true, false, " app ", " https://www.microsoft.com/en-us/p/bible-study-tools-audio-video/9nblggh64sqh?activetab=pivot:overviewtab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 4, " all ", false, false, false, false, " Free Microsoft learning apps ", false, true, " link ", " https://www.microsoft.com/en-us/search/shop/apps?q=apps&category=Education " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 9, " all ", false, false, false, false, " Abeka ", false, true, " books ", " https://www.abeka.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 8, " all ", false, false, false, false, " Sonlight ", false, true, " books ", " https://www.sonlight.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 7, " all ", false, false, false, false, " Alpha Omega Press ", false, true, " books ", " https://www.aop.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 6, " all ", false, false, false, false, " BJU Press ", false, true, " books ", " https://www.bjupresshomeschool.com/content/home " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 5, " all ", false, false, false, false, " Christian Liberty ", false, true, " books ", " https://www.shopchristianliberty.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 1, " all ", false, false, false, false, " OTrueford Podcasts ", false, true, " link ", " http://podcasts.oTrue.ac.uk/series " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 18, " all ", true, false, false, true, " Free Ed Dot Net ", true, false, " online ", " https://www.waybuilder.net/free-ed/AcademicCatalog.asp " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 19, " all ", false, false, false, false, " Khan Academy Kids ", true, false, " online ", " https://learn.khanacademy.org/khan-academy-kids/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 24, " all ", false, true, true, false, " Harvard ETruetension School ", false, false, " online ", " https://www.eTruetension.harvard.edu/open-learning-initiative " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 23, " all ", false, true, true, true, " Yale Open Courses ", false, false, " online ", " https://oyc.yale.edu/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 22, " all ", false, true, true, true, " UC Berkeley Free Online ", false, false, " online ", " https://www.classcentral.com/university/berkeley " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 21, " all ", false, true, true, true, " MIT Open Courseware ", false, false, " online ", " https://ocw.mit.edu/indeTrue.htm " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 20, " all ", false, true, true, true, " Carnagie Mellon Open Learning ", false, false, " online ", " http://oli.cmu.edu/independent-learner-courses/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 17, " all ", true, false, false, true, " All in One Homeschool ", true, false, " online ", " https://allinonehomeschool.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 10, " all ", false, false, false, false, " Hacking STEM Library ", false, true, " link ", " https://www.microsoft.com/en-us/education/education-workshop/activity-library.aspTrue " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 11, " all ", false, false, false, false, " TeTrueas Home School Coalition ", false, true, " link ", " https://thsc.org/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 12, " all ", false, false, false, false, " TED Ed ", false, true, " link ", " https://ed.ted.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 31, " english ", true, false, false, true, " Old Fashioned Education Science & Nature ", true, false, " online ", " http://oldfashionededucation.com/science.htm " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 30, " english ", true, false, false, true, " Old Fashioned Education Fairy tales ", true, false, " online ", " http://oldfashionededucation.com/fairytales.htm " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 32, " english ", true, false, false, false, " Khan Academy 2nd grade reading & Vocab ", false, false, " online ", " https://www.khanacademy.org/ela/cc-2nd-reading-vocab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 37, " english ", false, true, true, false, " Udemy English Literature ", false, false, " online ", " https://www.udemy.com/topic/english-literature/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 36, " english ", false, true, true, false, " Coursera English Composition I ", false, false, " online ", " https://www.coursera.org/learn/english-composition " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 33, " english ", false, true, true, true, " edTrue English Grammar & Style ", false, false, " online ", " https://www.edTrue.org/course/english-grammar-and-style " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 34, " english ", false, true, false, true, " Khan Academy Grammar ", false, false, " online ", " https://www.khanacademy.org/humanities/grammar " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 35, " english ", false, false, false, true, " Khan Academy 8th grade reading & Vocab ", false, false, " online ", " https://www.khanacademy.org/ela/cc-8th-reading-vocab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 38, " english ", false, false, false, false, " Kids Learn Spelling Fun ", false, false, " app ", " https://www.microsoft.com/en-us/p/kids-learn-spelling-fun-teaches-500-common-english-words/9nr1pw1s6p6v#activetab=pivot:overviewtab " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 3, " all ", true, false, false, false, " Funbrain ", true, true, " online ", " https://www.funbrain.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 2, " all ", true, false, false, false, " Whyville ", true, true, " online ", " http://www.whyville.net/smmk/nice " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 16, " all ", false, false, false, false, " iTunes U ", false, true, " link ", " https://apps.apple.com/ca/app/itunes-u/id490217893 " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 15, " all ", false, false, false, false, " Open Culture ", false, true, " link ", " http://www.openculture.com/freeonlinecourses " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 14, " all ", false, false, false, false, " codeacademy ", false, true, " link ", " https://www.codecademy.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 13, " all ", false, false, false, false, " Stanford Online ", false, true, " link ", " https://online.stanford.edu/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 63, " social studies ", false, false, false, false, " Apologia ", false, true, " books ", " https://www.apologia.com/ " });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 64, " social studies ", false, false, false, false, " Beautiful Feet Books ", false, true, " books ", " http://www.bfbooks.com/ " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
