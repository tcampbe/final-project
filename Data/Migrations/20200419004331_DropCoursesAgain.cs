using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class DropCoursesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Elementary = table.Column<bool>(type: "INTEGER", nullable: false),
                    HighSchool = table.Column<bool>(type: "INTEGER", nullable: false),
                    HigherEducation = table.Column<bool>(type: "INTEGER", nullable: false),
                    MiddleSchool = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PreSchool = table.Column<bool>(type: "INTEGER", nullable: false),
                    Resource = table.Column<bool>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    WebSite = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 25, "all", false, true, false, false, "AllinOneHighSchool", false, false, "online", "https://allinonehighschool.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 62, "science", false, true, false, false, "CourseraPlantsPartI", false, false, "online", "https://www.coursera.org/learn/plantknows" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 61, "science", false, true, false, false, "KhanAcademyAPPhysics2", false, false, "online", "https://www.khanacademy.org/science/physics/ap-physics-2" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 58, "science", false, true, false, true, "KhanAcademyBiology", false, false, "online", "https://www.khanacademy.org/science/biology" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 41, "math", false, false, false, false, "Math-U-See", false, true, "books", "https://www.mathusee.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 40, "math", false, false, false, false, "Miquon", false, true, "books", "https://miquonmath.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 39, "math", false, false, false, false, "Apologia", false, true, "books", "https://www.apologia.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 53, "science", false, true, true, true, "LearnHTML(5)", false, false, "app", "https://www.microsoft.com/en-us/p/learn-html-5/9nblggh31wfj?activetab=pivot:overviewtab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 43, "math", true, false, false, false, "KhanAcademyEarlyMath", true, false, "online", "https://www.khanacademy.org/math/early-math" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 48, "math", false, true, true, false, "UdemyGeometry", false, false, "online", "https://www.udemy.com/topic/geometry/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 47, "math", false, true, true, false, "CourseraIntrotoCalculus", false, false, "online", "https://www.coursera.org/learn/introduction-to-calculus" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 46, "math", false, true, true, false, "edTrueMathEssentials", false, false, "online", "https://www.edTrue.org/course/maths-essentials" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 44, "math", false, true, true, true, "AlisonCoreMathSkills", false, false, "online", "https://alison.com/courses/core-maths-skills" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 49, "math", false, true, false, false, "KhanAcademyHighSchoolMath", false, false, "online", "https://www.khanacademy.org/math/high-school-math" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 45, "math", false, true, false, true, "KhanAcademyPreAlgebra", false, false, "online", "https://www.khanacademy.org/math/pre-algebra" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 42, "math", true, false, false, true, "OldFashionedEducationArithmetic", true, false, "online", "http://oldfashionededucation.com/arithmetic_math.htm" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 28, "english", false, false, false, false, "Ambleside", false, true, "link", "https://www.amblesideonline.org/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 55, "science", false, true, true, true, "C++ProgrammingbyWagmob", false, false, "app", "https://www.microsoft.com/en-us/p/c-programming-by-wagmob/9wzdncrdn96h?activetab=pivot:overviewtab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 57, "science", false, true, true, true, "UdemyNutrition", false, false, "online", "https://www.udemy.com/topic/nutrition/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 65, "socialstudies", true, false, false, true, "OldFashionedEducationGeography", true, false, "online", "http://oldfashionededucation.com/geography.htm" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 66, "socialstudies", true, true, false, true, "KhanAcademyUSHistory", false, false, "online", "https://www.khanacademy.org/humanities/us-history" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 71, "socialstudies", false, true, true, false, "UdemyPsychology", false, false, "online", "https://www.udemy.com/topic/social-psychology/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 70, "socialstudies", false, true, true, false, "edTrueIntroductiontoAmericanGovernment", false, false, "online", "https://www.edTrue.org/Trueseries/harvardTrue-us-government" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 68, "socialstudies", false, true, true, true, "HilsdaleCollegeFreeCourses", false, false, "online", "https://www.hillsdale.edu/educational-outreach/free-online-courses/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 67, "socialstudies", false, true, true, true, "CourseraEconomicsofMoney", false, false, "online", "https://www.coursera.org/learn/money-banking" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 56, "science", false, true, true, true, "ChemistrybyWAGmob", false, false, "app", "https://www.microsoft.com/en-us/p/chemistry-by-wagmob/9wzdncrdn317?activetab=pivot:overviewtab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 72, "socialstudies", false, true, false, false, "KhanAcademyApWorldHistory", false, false, "online", "https://www.khanacademy.org/humanities/ap-world-history" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 51, "science", true, false, false, false, "NationalGeographicKids", true, true, "online", "https://kids.nationalgeographic.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 50, "science", false, false, false, false, "CODE", false, true, "link", "https://code.org/learn" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 52, "science", false, false, false, false, "Apologia", false, true, "books", "https://www.apologia.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 54, "science", true, false, false, true, "KhanAcademyHealth&Medicine", false, false, "online", "https://www.khanacademy.org/science/health-and-medicine" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 60, "science", false, true, true, false, "AcademicEarthChemistry", false, false, "online", "https://academicearth.org/chemistry/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 59, "science", false, true, true, false, "edTrueAppliedHumanAnatomy", false, false, "online", "https://www.edTrue.org/course/applied-anatomy-of-the-locomotor-system" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 69, "socialstudies", false, true, false, true, "KhanAcademyUSGovernment&Civics", false, false, "online", "https://www.khanacademy.org/humanities/us-government-and-civics" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 26, "english", false, false, false, false, "MemRise", false, true, "link", "https://www.memrise.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 27, "english", false, false, false, false, "RosettaStone", false, true, "books", "https://www.rosettastone.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 29, "english", true, true, true, true, "BibleStudyTools", true, false, "app", "https://www.microsoft.com/en-us/p/bible-study-tools-audio-video/9nblggh64sqh?activetab=pivot:overviewtab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 4, "all", false, false, false, false, "FreeMicrosoftlearningapps", false, true, "link", "https://www.microsoft.com/en-us/search/shop/apps?q=apps&category=Education" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 9, "all", false, false, false, false, "Abeka", false, true, "books", "https://www.abeka.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 8, "all", false, false, false, false, "Sonlight", false, true, "books", "https://www.sonlight.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 7, "all", false, false, false, false, "AlphaOmegaPress", false, true, "books", "https://www.aop.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 6, "all", false, false, false, false, "BJUPress", false, true, "books", "https://www.bjupresshomeschool.com/content/home" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 5, "all", false, false, false, false, "ChristianLiberty", false, true, "books", "https://www.shopchristianliberty.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 1, "all", false, false, false, false, "OTruefordPodcasts", false, true, "link", "http://podcasts.oTrue.ac.uk/series" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 18, "all", true, false, false, true, "FreeEdDotNet", true, false, "online", "https://www.waybuilder.net/free-ed/AcademicCatalog.asp" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 19, "all", false, false, false, false, "KhanAcademyKids", true, false, "online", "https://learn.khanacademy.org/khan-academy-kids/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 24, "all", false, true, true, false, "HarvardETruetensionSchool", false, false, "online", "https://www.eTruetension.harvard.edu/open-learning-initiative" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 23, "all", false, true, true, true, "YaleOpenCourses", false, false, "online", "https://oyc.yale.edu/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 22, "all", false, true, true, true, "UCBerkeleyFreeOnline", false, false, "online", "https://www.classcentral.com/university/berkeley" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 21, "all", false, true, true, true, "MITOpenCourseware", false, false, "online", "https://ocw.mit.edu/indeTrue.htm" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 20, "all", false, true, true, true, "CarnagieMellonOpenLearning", false, false, "online", "http://oli.cmu.edu/independent-learner-courses/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 17, "all", true, false, false, true, "AllinOneHomeschool", true, false, "online", "https://allinonehomeschool.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 10, "all", false, false, false, false, "HackingSTEMLibrary", false, true, "link", "https://www.microsoft.com/en-us/education/education-workshop/activity-library.aspTrue" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 11, "all", false, false, false, false, "TeTrueasHomeSchoolCoalition", false, true, "link", "https://thsc.org/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 12, "all", false, false, false, false, "TEDEd", false, true, "link", "https://ed.ted.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 31, "science", true, false, false, true, "OldFashionedEducationScience&Nature", true, false, "online", "http://oldfashionededucation.com/science.htm" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 30, "english", true, false, false, true, "OldFashionedEducationFairytales", true, false, "online", "http://oldfashionededucation.com/fairytales.htm" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 32, "english", true, false, false, false, "KhanAcademy2ndgradereading&Vocab", false, false, "online", "https://www.khanacademy.org/ela/cc-2nd-reading-vocab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 37, "english", false, true, true, false, "UdemyEnglishLiterature", false, false, "online", "https://www.udemy.com/topic/english-literature/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 36, "english", false, true, true, false, "CourseraEnglishCompositionI", false, false, "online", "https://www.coursera.org/learn/english-composition" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 33, "english", false, true, true, true, "edTrueEnglishGrammar&Style", false, false, "online", "https://www.edTrue.org/course/english-grammar-and-style" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 34, "english", false, true, false, true, "KhanAcademyGrammar", false, false, "online", "https://www.khanacademy.org/humanities/grammar" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 35, "english", false, false, false, true, "KhanAcademy8thgradereading&Vocab", false, false, "online", "https://www.khanacademy.org/ela/cc-8th-reading-vocab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 38, "english", false, false, false, false, "KidsLearnSpellingFun", false, false, "app", "https://www.microsoft.com/en-us/p/kids-learn-spelling-fun-teaches-500-common-english-words/9nr1pw1s6p6v#activetab=pivot:overviewtab" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 3, "all", true, false, false, false, "Funbrain", true, true, "online", "https://www.funbrain.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 2, "all", true, false, false, false, "Whyville", true, true, "online", "http://www.whyville.net/smmk/nice" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 16, "all", false, false, false, false, "iTunesU", false, true, "link", "https://apps.apple.com/ca/app/itunes-u/id490217893" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 15, "all", false, false, false, false, "OpenCulture", false, true, "link", "http://www.openculture.com/freeonlinecourses" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 14, "all", false, false, false, false, "codeacademy", false, true, "link", "https://www.codecademy.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 13, "all", false, false, false, false, "StanfordOnline", false, true, "link", "https://online.stanford.edu/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 63, "socialstudies", false, false, false, false, "Apologia", false, true, "books", "https://www.apologia.com/" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Elementary", "HighSchool", "HigherEducation", "MiddleSchool", "Name", "PreSchool", "Resource", "Type", "WebSite" },
                values: new object[] { 64, "socialstudies", false, false, false, false, "BeautifulFeetBooks", false, true, "books", "http://www.bfbooks.com/" });
        }
    }
}
