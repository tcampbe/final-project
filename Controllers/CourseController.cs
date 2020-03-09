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