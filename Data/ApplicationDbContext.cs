using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }


        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options, null)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Jon S", English = "Old Fashioned Education Fairy tales", Math = "Old Fashioned Education Arithmetic", Science = "Old Fashioned Education Science & Nature", SocialStudies = "Old Fashioned Education Geography " },
                new Student { Id = 2, Name = "Bobby M", English = "Khan Academy Grammar", Math = "Alison Core Math Skills", Science = "Khan Academy Biology", SocialStudies = "Hilsdale College Free Courses" },
                new Student { Id = 3, Name = "Sarah B", English = "Coursera English Composition I", Math = "Udemy Geometry", Science = "Academic Earth Chemistry", SocialStudies = "edX Introduction to American Government" }
                );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, FirstName = "Sam", LastName = "Smith" },
                new Teacher { Id = 2, FirstName = "Tom", LastName = "Miller" },
                new Teacher { Id = 3, FirstName = "Mary", LastName = "Brooks" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 25, Type = "onlineonline", Name = "AllinOneHighSchool", Category = "all", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = "https://allinonehighschool.com/" },
                new Course { Id = 20, Type = "onlineonline", Name = "CarnagieMellonOpenLearning", Category = "all", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "http://oli.cmu.edu/independent-learner-courses/" },
                new Course { Id = 21, Type = "onlineonline", Name = "MITOpenCourseware", Category = "all", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://ocw.mit.edu/indeTrue.htm" },
                new Course { Id = 22, Type = "onlineonline", Name = "UCBerkeleyFreeOnline", Category = "all", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.classcentral.com/university/berkeley" },
                new Course { Id = 23, Type = "onlineonline", Name = "YaleOpenCourses", Category = "all", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://oyc.yale.edu/" },
                new Course { Id = 24, Type = "onlineonline", Name = "HarvardETruetensionSchool", Category = "all", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.eTruetension.harvard.edu/open-learning-initiative" },
                new Course { Id = 19, Type = "onlineonline", Name = "KhanAcademyKids", Category = "all", Resource = false, PreSchool = true, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://learn.khanacademy.org/khan-academy-kids/" },
                new Course { Id = 17, Type = "onlineonline", Name = "AllinOneHomeschool", Category = "all", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "https://allinonehomeschool.com/" },
                new Course { Id = 18, Type = "onlineonline", Name = "FreeEdDotNet", Category = "all", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "https://www.waybuilder.net/free-ed/AcademicCatalog.asp" },
                new Course { Id = 5, Type = "booksbooks", Name = "ChristianLiberty", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.shopchristianliberty.com/" },
                new Course { Id = 6, Type = "booksbooks", Name = "BJUPress", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.bjupresshomeschool.com/content/home" },
                new Course { Id = 7, Type = "booksbooks", Name = "AlphaOmegaPress", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.aop.com/" },
                new Course { Id = 8, Type = "booksbooks", Name = "Sonlight", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.sonlight.com/" },
                new Course { Id = 9, Type = "booksbooks", Name = "Abeka", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.abeka.com/" },
                new Course { Id = 4, Type = "linklink", Name = "FreeMicrosoftlearningapps", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.microsoft.com/en-us/search/shop/apps?q=apps&category=Education" },
                new Course { Id = 1, Type = "linklink", Name = "OTruefordPodcasts", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "http://podcasts.oTrue.ac.uk/series" },
                new Course { Id = 10, Type = "linklink", Name = "HackingSTEMLibrary", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.microsoft.com/en-us/education/education-workshop/activity-library.aspTrue" },
                new Course { Id = 11, Type = "linklink", Name = "TeTrueasHomeSchoolCoalition", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://thsc.org/" },
                new Course { Id = 12, Type = "linklink", Name = "TEDEd", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://ed.ted.com/" },
                new Course { Id = 13, Type = "linklink", Name = "StanfordOnline", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://online.stanford.edu/" },
                new Course { Id = 14, Type = "linklink", Name = "codeacademy", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.codecademy.com/" },
                new Course { Id = 15, Type = "linklink", Name = "OpenCulture", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "http://www.openculture.com/freeonlinecourses" },
                new Course { Id = 16, Type = "linklink", Name = "iTunesU", Category = "all", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://apps.apple.com/ca/app/itunes-u/id490217893" },
                new Course { Id = 2, Type = "onlineonline", Name = "Whyville", Category = "all", Resource = true, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "http://www.whyville.net/smmk/nice" },
                new Course { Id = 3, Type = "onlineonline", Name = "Funbrain", Category = "all", Resource = true, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.funbrain.com/" },
                new Course { Id = 38, Type = "appapp", Name = "KidsLearnSpellingFun", Category = "english", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.microsoft.com/en-us/p/kids-learn-spelling-fun-teaches-500-common-english-words/9nr1pw1s6p6v#activetab=pivot:overviewtab" },
                new Course { Id = 35, Type = "onlineonline", Name = "KhanAcademy8thgradereading&Vocab", Category = "english", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "https://www.khanacademy.org/ela/cc-8th-reading-vocab" },
                new Course { Id = 34, Type = "onlineonline", Name = "KhanAcademyGrammar", Category = "english", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/humanities/grammar" },
                new Course { Id = 33, Type = "onlineonline", Name = "edTrueEnglishGrammar&Style", Category = "english", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.edTrue.org/course/english-grammar-and-style" },
                new Course { Id = 36, Type = "onlineonline", Name = "CourseraEnglishCompositionI", Category = "english", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.coursera.org/learn/english-composition" },
                new Course { Id = 37, Type = "onlineonline", Name = "UdemyEnglishLiterature", Category = "english", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.udemy.com/topic/english-literature/" },
                new Course { Id = 32, Type = "onlineonline", Name = "KhanAcademy2ndgradereading&Vocab", Category = "english", Resource = false, PreSchool = false, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.khanacademy.org/ela/cc-2nd-reading-vocab" },
                new Course { Id = 30, Type = "onlineonline", Name = "OldFashionedEducationFairytales", Category = "english", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "http://oldfashionededucation.com/fairytales.htm" },
                new Course { Id = 31, Type = "onlineonline", Name = "OldFashionedEducationScience&Nature", Category = "science", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "http://oldfashionededucation.com/science.htm" },
                new Course { Id = 29, Type = "appapp", Name = "BibleStudyTools", Category = "english", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.microsoft.com/en-us/p/bible-study-tools-audio-video/9nblggh64sqh?activetab=pivot:overviewtab" },
                new Course { Id = 27, Type = "booksbooks", Name = "RosettaStone", Category = "english", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.rosettastone.com/" },
                new Course { Id = 26, Type = "linklink", Name = "MemRise", Category = "english", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.memrise.com/" },
                new Course { Id = 28, Type = "linklink", Name = "Ambleside", Category = "english", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.amblesideonline.org/" },
                new Course { Id = 45, Type = "onlineonline", Name = "KhanAcademyPreAlgebra", Category = "math", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/math/pre-algebra" },
                new Course { Id = 49, Type = "onlineonline", Name = "KhanAcademyHighSchoolMath", Category = "math", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/math/high-school-math" },
                new Course { Id = 44, Type = "onlineonline", Name = "AlisonCoreMathSkills", Category = "math", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://alison.com/courses/core-maths-skills" },
                new Course { Id = 46, Type = "onlineonline", Name = "edTrueMathEssentials", Category = "math", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.edTrue.org/course/maths-essentials" },
                new Course { Id = 47, Type = "onlineonline", Name = "CourseraIntrotoCalculus", Category = "math", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.coursera.org/learn/introduction-to-calculus" },
                new Course { Id = 48, Type = "onlineonline", Name = "UdemyGeometry", Category = "math", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.udemy.com/topic/geometry/" },
                new Course { Id = 42, Type = "onlineonline", Name = "OldFashionedEducationArithmetic", Category = "math", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "http://oldfashionededucation.com/arithmetic_math.htm" },
                new Course { Id = 43, Type = "onlineonline", Name = "KhanAcademyEarlyMath", Category = "math", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.khanacademy.org/math/early-math" },
                new Course { Id = 39, Type = "booksbooks", Name = "Apologia", Category = "math", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.apologia.com/" },
                new Course { Id = 40, Type = "booksbooks", Name = "Miquon", Category = "math", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://miquonmath.com/" },
                new Course { Id = 41, Type = "booksbooks", Name = "Math-U-See", Category = "math", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.mathusee.com/" },
                new Course { Id = 58, Type = "onlineonline", Name = "KhanAcademyBiology", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/science/biology" },
                new Course { Id = 61, Type = "onlineonline", Name = "KhanAcademyAPPhysics2", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/science/physics/ap-physics-2" },
                new Course { Id = 62, Type = "onlineonline", Name = "CourseraPlantsPartI", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = "https://www.coursera.org/learn/plantknows" },
                new Course { Id = 53, Type = "appapp", Name = "LearnHTML(5)", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.microsoft.com/en-us/p/learn-html-5/9nblggh31wfj?activetab=pivot:overviewtab" },
                new Course { Id = 55, Type = "appapp", Name = "C++ProgrammingbyWagmob", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.microsoft.com/en-us/p/c-programming-by-wagmob/9wzdncrdn96h?activetab=pivot:overviewtab" },
                new Course { Id = 56, Type = "appapp", Name = "ChemistrybyWAGmob", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.microsoft.com/en-us/p/chemistry-by-wagmob/9wzdncrdn317?activetab=pivot:overviewtab" },
                new Course { Id = 57, Type = "onlineonline", Name = "UdemyNutrition", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.udemy.com/topic/nutrition/" },
                new Course { Id = 59, Type = "onlineonline", Name = "edTrueAppliedHumanAnatomy", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.edTrue.org/course/applied-anatomy-of-the-locomotor-system" },
                new Course { Id = 60, Type = "onlineonline", Name = "AcademicEarthChemistry", Category = "science", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://academicearth.org/chemistry/" },
                new Course { Id = 54, Type = "onlineonline", Name = "KhanAcademyHealth&Medicine", Category = "science", Resource = false, PreSchool = false, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "https://www.khanacademy.org/science/health-and-medicine" },
                new Course { Id = 52, Type = "booksbooks", Name = "Apologia", Category = "science", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.apologia.com/" },
                new Course { Id = 50, Type = "linklink", Name = "CODE", Category = "science", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://code.org/learn" },
                new Course { Id = 51, Type = "onlineonline", Name = "NationalGeographicKids", Category = "science", Resource = true, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://kids.nationalgeographic.com/" },
                new Course { Id = 69, Type = "onlineonline", Name = "KhanAcademyUSGovernment&Civics", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/humanities/us-government-and-civics" },
                new Course { Id = 72, Type = "onlineonline", Name = "KhanAcademyApWorldHistory", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/humanities/ap-world-history" },
                new Course { Id = 67, Type = "onlineonline", Name = "CourseraEconomicsofMoney", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.coursera.org/learn/money-banking" },
                new Course { Id = 68, Type = "onlineonline", Name = "HilsdaleCollegeFreeCourses", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = "https://www.hillsdale.edu/educational-outreach/free-online-courses/" },
                new Course { Id = 70, Type = "onlineonline", Name = "edTrueIntroductiontoAmericanGovernment", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.edTrue.org/Trueseries/harvardTrue-us-government" },
                new Course { Id = 71, Type = "onlineonline", Name = "UdemyPsychology", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = "https://www.udemy.com/topic/social-psychology/" },
                new Course { Id = 66, Type = "onlineonline", Name = "KhanAcademyUSHistory", Category = "socialstudies", Resource = false, PreSchool = false, Elementary = true, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = "https://www.khanacademy.org/humanities/us-history" },
                new Course { Id = 65, Type = "onlineonline", Name = "OldFashionedEducationGeography", Category = "socialstudies", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = "http://oldfashionededucation.com/geography.htm" },
                new Course { Id = 63, Type = "booksbooks", Name = "Apologia", Category = "socialstudies", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "https://www.apologia.com/" },
                new Course { Id = 64, Type = "booksbooks", Name = "BeautifulFeetBooks", Category = "socialstudies", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = "http://www.bfbooks.com/" }
            );
        }
    }
}
