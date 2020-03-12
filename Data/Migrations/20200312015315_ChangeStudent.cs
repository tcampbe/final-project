using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class ChangeStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    English = table.Column<string>(nullable: true),
                    Math = table.Column<string>(nullable: true),
                    Science = table.Column<string>(nullable: true),
                    SocialStudies = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Name);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "OTruefordPodcasts", "linklink", "http://podcasts.oTrue.ac.uk/series" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "Whyville", "onlineonline", "http://www.whyville.net/smmk/nice" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "Funbrain", "onlineonline", "https://www.funbrain.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "FreeMicrosoftlearningapps", "linklink", "https://www.microsoft.com/en-us/search/shop/apps?q=apps&category=Education" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "ChristianLiberty", "booksbooks", "https://www.shopchristianliberty.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "BJUPress", "booksbooks", "https://www.bjupresshomeschool.com/content/home" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "AlphaOmegaPress", "booksbooks", "https://www.aop.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "Sonlight", "booksbooks", "https://www.sonlight.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "Abeka", "booksbooks", "https://www.abeka.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "HackingSTEMLibrary", "linklink", "https://www.microsoft.com/en-us/education/education-workshop/activity-library.aspTrue" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "TeTrueasHomeSchoolCoalition", "linklink", "https://thsc.org/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "TEDEd", "linklink", "https://ed.ted.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "StanfordOnline", "linklink", "https://online.stanford.edu/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "codeacademy", "linklink", "https://www.codecademy.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "OpenCulture", "linklink", "http://www.openculture.com/freeonlinecourses" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "iTunesU", "linklink", "https://apps.apple.com/ca/app/itunes-u/id490217893" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "AllinOneHomeschool", "onlineonline", "https://allinonehomeschool.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "FreeEdDotNet", "onlineonline", "https://www.waybuilder.net/free-ed/AcademicCatalog.asp" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "KhanAcademyKids", "onlineonline", "https://learn.khanacademy.org/khan-academy-kids/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "CarnagieMellonOpenLearning", "onlineonline", "http://oli.cmu.edu/independent-learner-courses/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "MITOpenCourseware", "onlineonline", "https://ocw.mit.edu/indeTrue.htm" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "UCBerkeleyFreeOnline", "onlineonline", "https://www.classcentral.com/university/berkeley" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "YaleOpenCourses", "onlineonline", "https://oyc.yale.edu/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "HarvardETruetensionSchool", "onlineonline", "https://www.eTruetension.harvard.edu/open-learning-initiative" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "all", "AllinOneHighSchool", "onlineonline", "https://allinonehighschool.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "MemRise", "linklink", "https://www.memrise.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "RosettaStone", "booksbooks", "https://www.rosettastone.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "Ambleside", "linklink", "https://www.amblesideonline.org/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "BibleStudyTools", "appapp", "https://www.microsoft.com/en-us/p/bible-study-tools-audio-video/9nblggh64sqh?activetab=pivot:overviewtab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "OldFashionedEducationFairytales", "onlineonline", "http://oldfashionededucation.com/fairytales.htm" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "OldFashionedEducationScience&Nature", "onlineonline", "http://oldfashionededucation.com/science.htm" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "KhanAcademy2ndgradereading&Vocab", "onlineonline", "https://www.khanacademy.org/ela/cc-2nd-reading-vocab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "edTrueEnglishGrammar&Style", "onlineonline", "https://www.edTrue.org/course/english-grammar-and-style" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "KhanAcademyGrammar", "onlineonline", "https://www.khanacademy.org/humanities/grammar" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "KhanAcademy8thgradereading&Vocab", "onlineonline", "https://www.khanacademy.org/ela/cc-8th-reading-vocab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "CourseraEnglishCompositionI", "onlineonline", "https://www.coursera.org/learn/english-composition" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "UdemyEnglishLiterature", "onlineonline", "https://www.udemy.com/topic/english-literature/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "english", "KidsLearnSpellingFun", "appapp", "https://www.microsoft.com/en-us/p/kids-learn-spelling-fun-teaches-500-common-english-words/9nr1pw1s6p6v#activetab=pivot:overviewtab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "Apologia", "booksbooks", "https://www.apologia.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "Miquon", "booksbooks", "https://miquonmath.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "Math-U-See", "booksbooks", "https://www.mathusee.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "OldFashionedEducationArithmetic", "onlineonline", "http://oldfashionededucation.com/arithmetic_math.htm" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "KhanAcademyEarlyMath", "onlineonline", "https://www.khanacademy.org/math/early-math" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "AlisonCoreMathSkills", "onlineonline", "https://alison.com/courses/core-maths-skills" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "KhanAcademyPreAlgebra", "onlineonline", "https://www.khanacademy.org/math/pre-algebra" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "edTrueMathEssentials", "onlineonline", "https://www.edTrue.org/course/maths-essentials" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "CourseraIntrotoCalculus", "onlineonline", "https://www.coursera.org/learn/introduction-to-calculus" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "UdemyGeometry", "onlineonline", "https://www.udemy.com/topic/geometry/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "math", "KhanAcademyHighSchoolMath", "onlineonline", "https://www.khanacademy.org/math/high-school-math" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "CODE", "linklink", "https://code.org/learn" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "NationalGeographicKids", "onlineonline", "https://kids.nationalgeographic.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "Apologia", "booksbooks", "https://www.apologia.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "LearnHTML(5)", "appapp", "https://www.microsoft.com/en-us/p/learn-html-5/9nblggh31wfj?activetab=pivot:overviewtab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "KhanAcademyHealth&Medicine", "onlineonline", "https://www.khanacademy.org/science/health-and-medicine" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "C++ProgrammingbyWagmob", "appapp", "https://www.microsoft.com/en-us/p/c-programming-by-wagmob/9wzdncrdn96h?activetab=pivot:overviewtab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "ChemistrybyWAGmob", "appapp", "https://www.microsoft.com/en-us/p/chemistry-by-wagmob/9wzdncrdn317?activetab=pivot:overviewtab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "UdemyNutrition", "onlineonline", "https://www.udemy.com/topic/nutrition/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "KhanAcademyBiology", "onlineonline", "https://www.khanacademy.org/science/biology" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "edTrueAppliedHumanAnatomy", "onlineonline", "https://www.edTrue.org/course/applied-anatomy-of-the-locomotor-system" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "AcademicEarthChemistry", "onlineonline", "https://academicearth.org/chemistry/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "KhanAcademyAPPhysics2", "onlineonline", "https://www.khanacademy.org/science/physics/ap-physics-2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "science", "CourseraPlantsPartI", "onlineonline", "https://www.coursera.org/learn/plantknows" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "Apologia", "booksbooks", "https://www.apologia.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "BeautifulFeetBooks", "booksbooks", "http://www.bfbooks.com/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "OldFashionedEducationGeography", "onlineonline", "http://oldfashionededucation.com/geography.htm" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "KhanAcademyUSHistory", "onlineonline", "https://www.khanacademy.org/humanities/us-history" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "CourseraEconomicsofMoney", "onlineonline", "https://www.coursera.org/learn/money-banking" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "HilsdaleCollegeFreeCourses", "onlineonline", "https://www.hillsdale.edu/educational-outreach/free-online-courses/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "KhanAcademyUSGovernment&Civics", "onlineonline", "https://www.khanacademy.org/humanities/us-government-and-civics" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "edTrueIntroductiontoAmericanGovernment", "onlineonline", "https://www.edTrue.org/Trueseries/harvardTrue-us-government" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "UdemyPsychology", "onlineonline", "https://www.udemy.com/topic/social-psychology/" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { "socialstudies", "KhanAcademyApWorldHistory", "onlineonline", "https://www.khanacademy.org/humanities/ap-world-history" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Name", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { "Bobby M", "Khan Academy Grammar", "Alison Core Math Skills", "Khan Academy Biology", "Hilsdale College Free Courses" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Name", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { "Sarah B", "Coursera English Composition I", "Udemy Geometry", "Academic Earth Chemistry", "edX Introduction to American Government" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Name", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { "Jon S", "Old Fashioned Education Fairy tales", "Old Fashioned Education Arithmetic", "Old Fashioned Education Science & Nature", "Old Fashioned Education Geography " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " OTrueford Podcasts ", " link ", " http://podcasts.oTrue.ac.uk/series " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Whyville ", " online ", " http://www.whyville.net/smmk/nice " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Funbrain ", " online ", " https://www.funbrain.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Free Microsoft learning apps ", " link ", " https://www.microsoft.com/en-us/search/shop/apps?q=apps&category=Education " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Christian Liberty ", " books ", " https://www.shopchristianliberty.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " BJU Press ", " books ", " https://www.bjupresshomeschool.com/content/home " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Alpha Omega Press ", " books ", " https://www.aop.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Sonlight ", " books ", " https://www.sonlight.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Abeka ", " books ", " https://www.abeka.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Hacking STEM Library ", " link ", " https://www.microsoft.com/en-us/education/education-workshop/activity-library.aspTrue " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " TeTrueas Home School Coalition ", " link ", " https://thsc.org/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " TED Ed ", " link ", " https://ed.ted.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Stanford Online ", " link ", " https://online.stanford.edu/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " codeacademy ", " link ", " https://www.codecademy.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Open Culture ", " link ", " http://www.openculture.com/freeonlinecourses " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " iTunes U ", " link ", " https://apps.apple.com/ca/app/itunes-u/id490217893 " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " All in One Homeschool ", " online ", " https://allinonehomeschool.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Free Ed Dot Net ", " online ", " https://www.waybuilder.net/free-ed/AcademicCatalog.asp " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Khan Academy Kids ", " online ", " https://learn.khanacademy.org/khan-academy-kids/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Carnagie Mellon Open Learning ", " online ", " http://oli.cmu.edu/independent-learner-courses/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " MIT Open Courseware ", " online ", " https://ocw.mit.edu/indeTrue.htm " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " UC Berkeley Free Online ", " online ", " https://www.classcentral.com/university/berkeley " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Yale Open Courses ", " online ", " https://oyc.yale.edu/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " Harvard ETruetension School ", " online ", " https://www.eTruetension.harvard.edu/open-learning-initiative " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " all ", " All in One High School ", " online ", " https://allinonehighschool.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " MemRise ", " link ", " https://www.memrise.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Rosetta Stone ", " books ", " https://www.rosettastone.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Ambleside ", " link ", " https://www.amblesideonline.org/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Bible Study Tools ", " app ", " https://www.microsoft.com/en-us/p/bible-study-tools-audio-video/9nblggh64sqh?activetab=pivot:overviewtab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Old Fashioned Education Fairy tales ", " online ", " http://oldfashionededucation.com/fairytales.htm " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Old Fashioned Education Science & Nature ", " online ", " http://oldfashionededucation.com/science.htm " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Khan Academy 2nd grade reading & Vocab ", " online ", " https://www.khanacademy.org/ela/cc-2nd-reading-vocab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " edTrue English Grammar & Style ", " online ", " https://www.edTrue.org/course/english-grammar-and-style " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Khan Academy Grammar ", " online ", " https://www.khanacademy.org/humanities/grammar " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Khan Academy 8th grade reading & Vocab ", " online ", " https://www.khanacademy.org/ela/cc-8th-reading-vocab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Coursera English Composition I ", " online ", " https://www.coursera.org/learn/english-composition " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Udemy English Literature ", " online ", " https://www.udemy.com/topic/english-literature/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " english ", " Kids Learn Spelling Fun ", " app ", " https://www.microsoft.com/en-us/p/kids-learn-spelling-fun-teaches-500-common-english-words/9nr1pw1s6p6v#activetab=pivot:overviewtab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Apologia ", " books ", " https://www.apologia.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Miquon ", " books ", " https://miquonmath.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Math-U-See ", " books ", " https://www.mathusee.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Old Fashioned Education Arithmetic ", " online ", " http://oldfashionededucation.com/arithmetic_math.htm " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Khan Academy Early Math ", " online ", " https://www.khanacademy.org/math/early-math " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Alison Core Math Skills ", " online ", " https://alison.com/courses/core-maths-skills " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Khan Academy PreAlgebra ", " online ", " https://www.khanacademy.org/math/pre-algebra " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " edTrue Math Essentials ", " online ", " https://www.edTrue.org/course/maths-essentials " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Coursera Intro to Calculus ", " online ", " https://www.coursera.org/learn/introduction-to-calculus " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Udemy Geometry ", " online ", " https://www.udemy.com/topic/geometry/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " math ", " Khan Academy High School Math ", " online ", " https://www.khanacademy.org/math/high-school-math " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " C O D E ", " link ", " https://code.org/learn " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " National Geographic Kids ", " online ", " https://kids.nationalgeographic.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Apologia ", " books ", " https://www.apologia.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Learn HTML(5) ", " app ", " https://www.microsoft.com/en-us/p/learn-html-5/9nblggh31wfj?activetab=pivot:overviewtab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Khan Academy Health & Medicine ", " online ", " https://www.khanacademy.org/science/health-and-medicine " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " C++ Programming by Wagmob ", " app ", " https://www.microsoft.com/en-us/p/c-programming-by-wagmob/9wzdncrdn96h?activetab=pivot:overviewtab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Chemistry by WAGmob ", " app ", " https://www.microsoft.com/en-us/p/chemistry-by-wagmob/9wzdncrdn317?activetab=pivot:overviewtab " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Udemy Nutrition ", " online ", " https://www.udemy.com/topic/nutrition/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Khan Academy Biology ", " online ", " https://www.khanacademy.org/science/biology " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " edTrue Applied Human Anatomy  ", " online ", " https://www.edTrue.org/course/applied-anatomy-of-the-locomotor-system " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Academic Earth Chemistry ", " online ", " https://academicearth.org/chemistry/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Khan Academy AP Physics 2 ", " online ", " https://www.khanacademy.org/science/physics/ap-physics-2 " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " science ", " Coursera Plants Part I ", " online ", " https://www.coursera.org/learn/plantknows " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Apologia ", " books ", " https://www.apologia.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Beautiful Feet Books ", " books ", " http://www.bfbooks.com/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Old Fashioned Education Geography  ", " online ", " http://oldfashionededucation.com/geography.htm " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Khan Academy US History ", " online ", " https://www.khanacademy.org/humanities/us-history " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Coursera Economics of Money  ", " online ", " https://www.coursera.org/learn/money-banking " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Hilsdale College Free Courses ", " online ", " https://www.hillsdale.edu/educational-outreach/free-online-courses/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Khan Academy US Government & Civics ", " online ", " https://www.khanacademy.org/humanities/us-government-and-civics " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " edTrue Introduction to American Government ", " online ", " https://www.edTrue.org/Trueseries/harvardTrue-us-government " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Udemy Psychology ", " online ", " https://www.udemy.com/topic/social-psychology/ " });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Name", "Type", "WebSite" },
                values: new object[] { " social studies ", " Khan Academy Ap World History ", " online ", " https://www.khanacademy.org/humanities/ap-world-history " });
        }
    }
}
