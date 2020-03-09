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
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options,null)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Jon", LastName = "Smith" },
                new Student { Id = 2, FirstName = "Bobby", LastName = "Miller" },
                new Student { Id = 3, FirstName = "Sarah", LastName = "Brooks" }
            );


            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, FirstName = "Sam", LastName = "Smith" },
                new Teacher { Id = 2, FirstName = "Tom", LastName = "Miller" },
                new Teacher { Id = 3, FirstName = "Mary", LastName = "Brooks" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 25, Type = " online ", Name = " All in One High School ", Category = " all ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = " https://allinonehighschool.com/ " },
                new Course { Id = 20, Type = " online ", Name = " Carnagie Mellon Open Learning ", Category = " all ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " http://oli.cmu.edu/independent-learner-courses/ " },
                new Course { Id = 21, Type = " online ", Name = " MIT Open Courseware ", Category = " all ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://ocw.mit.edu/indeTrue.htm " },
                new Course { Id = 22, Type = " online ", Name = " UC Berkeley Free Online ", Category = " all ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.classcentral.com/university/berkeley " },
                new Course { Id = 23, Type = " online ", Name = " Yale Open Courses ", Category = " all ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://oyc.yale.edu/ " },
                new Course { Id = 24, Type = " online ", Name = " Harvard ETruetension School ", Category = " all ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.eTruetension.harvard.edu/open-learning-initiative " },
                new Course { Id = 19, Type = " online ", Name = " Khan Academy Kids ", Category = " all ", Resource = false, PreSchool = true, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://learn.khanacademy.org/khan-academy-kids/ " },
                new Course { Id = 17, Type = " online ", Name = " All in One Homeschool ", Category = " all ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " https://allinonehomeschool.com/ " },
                new Course { Id = 18, Type = " online ", Name = " Free Ed Dot Net ", Category = " all ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " https://www.waybuilder.net/free-ed/AcademicCatalog.asp " },
                new Course { Id = 5, Type = " books ", Name = " Christian Liberty ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.shopchristianliberty.com/ " },
                new Course { Id = 6, Type = " books ", Name = " BJU Press ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.bjupresshomeschool.com/content/home " },
                new Course { Id = 7, Type = " books ", Name = " Alpha Omega Press ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.aop.com/ " },
                new Course { Id = 8, Type = " books ", Name = " Sonlight ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.sonlight.com/ " },
                new Course { Id = 9, Type = " books ", Name = " Abeka ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.abeka.com/ " },
                new Course { Id = 4, Type = " link ", Name = " Free Microsoft learning apps ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.microsoft.com/en-us/search/shop/apps?q=apps&category=Education " },
                new Course { Id = 1, Type = " link ", Name = " OTrueford Podcasts ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " http://podcasts.oTrue.ac.uk/series " },
                new Course { Id = 10, Type = " link ", Name = " Hacking STEM Library ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.microsoft.com/en-us/education/education-workshop/activity-library.aspTrue " },
                new Course { Id = 11, Type = " link ", Name = " TeTrueas Home School Coalition ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://thsc.org/ " },
                new Course { Id = 12, Type = " link ", Name = " TED Ed ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://ed.ted.com/ " },
                new Course { Id = 13, Type = " link ", Name = " Stanford Online ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://online.stanford.edu/ " },
                new Course { Id = 14, Type = " link ", Name = " codeacademy ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.codecademy.com/ " },
                new Course { Id = 15, Type = " link ", Name = " Open Culture ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " http://www.openculture.com/freeonlinecourses " },
                new Course { Id = 16, Type = " link ", Name = " iTunes U ", Category = " all ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://apps.apple.com/ca/app/itunes-u/id490217893 " },
                new Course { Id = 2, Type = " online ", Name = " Whyville ", Category = " all ", Resource = true, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " http://www.whyville.net/smmk/nice " },
                new Course { Id = 3, Type = " online ", Name = " Funbrain ", Category = " all ", Resource = true, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.funbrain.com/ " },
                new Course { Id = 38, Type = " app ", Name = " Kids Learn Spelling Fun ", Category = " english ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.microsoft.com/en-us/p/kids-learn-spelling-fun-teaches-500-common-english-words/9nr1pw1s6p6v#activetab=pivot:overviewtab " },
                new Course { Id = 35, Type = " online ", Name = " Khan Academy 8th grade reading & Vocab ", Category = " english ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " https://www.khanacademy.org/ela/cc-8th-reading-vocab " },
                new Course { Id = 34, Type = " online ", Name = " Khan Academy Grammar ", Category = " english ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/humanities/grammar " },
                new Course { Id = 33, Type = " online ", Name = " edTrue English Grammar & Style ", Category = " english ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.edTrue.org/course/english-grammar-and-style " },
                new Course { Id = 36, Type = " online ", Name = " Coursera English Composition I ", Category = " english ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.coursera.org/learn/english-composition " },
                new Course { Id = 37, Type = " online ", Name = " Udemy English Literature ", Category = " english ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.udemy.com/topic/english-literature/ " },
                new Course { Id = 32, Type = " online ", Name = " Khan Academy 2nd grade reading & Vocab ", Category = " english ", Resource = false, PreSchool = false, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.khanacademy.org/ela/cc-2nd-reading-vocab " },
                new Course { Id = 30, Type = " online ", Name = " Old Fashioned Education Fairy tales ", Category = " english ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " http://oldfashionededucation.com/fairytales.htm " },
                new Course { Id = 31, Type = " online ", Name = " Old Fashioned Education Science & Nature ", Category = " english ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " http://oldfashionededucation.com/science.htm " },
                new Course { Id = 29, Type = " app ", Name = " Bible Study Tools ", Category = " english ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.microsoft.com/en-us/p/bible-study-tools-audio-video/9nblggh64sqh?activetab=pivot:overviewtab " },
                new Course { Id = 27, Type = " books ", Name = " Rosetta Stone ", Category = " english ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.rosettastone.com/ " },
                new Course { Id = 26, Type = " link ", Name = " MemRise ", Category = " english ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.memrise.com/ " },
                new Course { Id = 28, Type = " link ", Name = " Ambleside ", Category = " english ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.amblesideonline.org/ " },
                new Course { Id = 45, Type = " online ", Name = " Khan Academy PreAlgebra ", Category = " math ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/math/pre-algebra " },
                new Course { Id = 49, Type = " online ", Name = " Khan Academy High School Math ", Category = " math ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/math/high-school-math " },
                new Course { Id = 44, Type = " online ", Name = " Alison Core Math Skills ", Category = " math ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://alison.com/courses/core-maths-skills " },
                new Course { Id = 46, Type = " online ", Name = " edTrue Math Essentials ", Category = " math ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.edTrue.org/course/maths-essentials " },
                new Course { Id = 47, Type = " online ", Name = " Coursera Intro to Calculus ", Category = " math ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.coursera.org/learn/introduction-to-calculus " },
                new Course { Id = 48, Type = " online ", Name = " Udemy Geometry ", Category = " math ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.udemy.com/topic/geometry/ " },
                new Course { Id = 42, Type = " online ", Name = " Old Fashioned Education Arithmetic ", Category = " math ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " http://oldfashionededucation.com/arithmetic_math.htm " },
                new Course { Id = 43, Type = " online ", Name = " Khan Academy Early Math ", Category = " math ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.khanacademy.org/math/early-math " },
                new Course { Id = 39, Type = " books ", Name = " Apologia ", Category = " math ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.apologia.com/ " },
                new Course { Id = 40, Type = " books ", Name = " Miquon ", Category = " math ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://miquonmath.com/ " },
                new Course { Id = 41, Type = " books ", Name = " Math-U-See ", Category = " math ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.mathusee.com/ " },
                new Course { Id = 58, Type = " online ", Name = " Khan Academy Biology ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/science/biology " },
                new Course { Id = 61, Type = " online ", Name = " Khan Academy AP Physics 2 ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/science/physics/ap-physics-2 " },
                new Course { Id = 62, Type = " online ", Name = " Coursera Plants Part I ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = " https://www.coursera.org/learn/plantknows " },
                new Course { Id = 53, Type = " app ", Name = " Learn HTML(5) ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.microsoft.com/en-us/p/learn-html-5/9nblggh31wfj?activetab=pivot:overviewtab " },
                new Course { Id = 55, Type = " app ", Name = " C++ Programming by Wagmob ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.microsoft.com/en-us/p/c-programming-by-wagmob/9wzdncrdn96h?activetab=pivot:overviewtab " },
                new Course { Id = 56, Type = " app ", Name = " Chemistry by WAGmob ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.microsoft.com/en-us/p/chemistry-by-wagmob/9wzdncrdn317?activetab=pivot:overviewtab " },
                new Course { Id = 57, Type = " online ", Name = " Udemy Nutrition ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.udemy.com/topic/nutrition/ " },
                new Course { Id = 59, Type = " online ", Name = " edTrue Applied Human Anatomy  ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.edTrue.org/course/applied-anatomy-of-the-locomotor-system " },
                new Course { Id = 60, Type = " online ", Name = " Academic Earth Chemistry ", Category = " science ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://academicearth.org/chemistry/ " },
                new Course { Id = 54, Type = " online ", Name = " Khan Academy Health & Medicine ", Category = " science ", Resource = false, PreSchool = false, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " https://www.khanacademy.org/science/health-and-medicine " },
                new Course { Id = 52, Type = " books ", Name = " Apologia ", Category = " science ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.apologia.com/ " },
                new Course { Id = 50, Type = " link ", Name = " C O D E ", Category = " science ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://code.org/learn " },
                new Course { Id = 51, Type = " online ", Name = " National Geographic Kids ", Category = " science ", Resource = true, PreSchool = true, Elementary = true, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://kids.nationalgeographic.com/ " },
                new Course { Id = 69, Type = " online ", Name = " Khan Academy US Government & Civics ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/humanities/us-government-and-civics " },
                new Course { Id = 72, Type = " online ", Name = " Khan Academy Ap World History ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/humanities/ap-world-history " },
                new Course { Id = 67, Type = " online ", Name = " Coursera Economics of Money  ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.coursera.org/learn/money-banking " },
                new Course { Id = 68, Type = " online ", Name = " Hilsdale College Free Courses ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = true, HighSchool = true, HigherEducation = true, WebSite = " https://www.hillsdale.edu/educational-outreach/free-online-courses/ " },
                new Course { Id = 70, Type = " online ", Name = " edTrue Introduction to American Government ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.edTrue.org/Trueseries/harvardTrue-us-government " },
                new Course { Id = 71, Type = " online ", Name = " Udemy Psychology ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = true, HigherEducation = true, WebSite = " https://www.udemy.com/topic/social-psychology/ " },
                new Course { Id = 66, Type = " online ", Name = " Khan Academy US History ", Category = " social studies ", Resource = false, PreSchool = false, Elementary = true, MiddleSchool = true, HighSchool = true, HigherEducation = false, WebSite = " https://www.khanacademy.org/humanities/us-history " },
                new Course { Id = 65, Type = " online ", Name = " Old Fashioned Education Geography  ", Category = " social studies ", Resource = false, PreSchool = true, Elementary = true, MiddleSchool = true, HighSchool = false, HigherEducation = false, WebSite = " http://oldfashionededucation.com/geography.htm " },
                new Course { Id = 63, Type = " books ", Name = " Apologia ", Category = " social studies ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " https://www.apologia.com/ " },
                new Course { Id = 64, Type = " books ", Name = " Beautiful Feet Books ", Category = " social studies ", Resource = true, PreSchool = false, Elementary = false, MiddleSchool = false, HighSchool = false, HigherEducation = false, WebSite = " http://www.bfbooks.com/ " }
            );

        }
    }
}
