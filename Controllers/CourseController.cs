using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]

    public class CourseController : ControllerBase
    {
        //querying for catagories

        //var blog = context.Blogs
        //            .Where(b => b.Name == "ADO.NET Blog")
        //            .FirstOrDefault();
        //https://docs.microsoft.com/en-us/ef/core/querying/

        //https://docs.microsoft.com/en-us/ef/ef6/querying/#finding-entities-using-a-query

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            Course[] courses = null;
            using (var context = new ApplicationDbContext())
            {
                courses = context.Courses.ToArray();
            }
            return courses;

        }

        [HttpGet("category")]
        public IEnumerable<Course> GetByCategory(string category)
        {
            Course[] categoryCourses = null;
            using (var context = new ApplicationDbContext())
            {
                //var allCourses = context.Courses.Where(c => c.Category == "all");
                //var englishCourses = context.Courses.Where(c => c.Category == "english");
                //var mathCourses = context.Courses.Where(c => c.Category == "math");
                //var scienceCourses = context.Courses.Where(c => c.Category == "science");
                //var socialStudiesCourses = context.Courses.Where(c => c.Category == "socialStudies");
                categoryCourses = context.Courses.Where(c => c.Category == category).ToArray();
            }

            return categoryCourses;

        }

        //[HttpGet("random")]
        //public IActionResult GetRandomQuiz(int id)
        //{
        //    //ModelState.AddModelError("GetRandomQuiz", "Not Implemented!");
        //    //return BadRequest(ModelState);
        //    var quiz = _quizService.GetRandomQuiz();
        //    return Ok(quiz.ToApiModel());

        //    https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-3.1
        //}

        [HttpPost]
        public Course Post([FromBody]Course course)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
            return course;
        }
    }
}