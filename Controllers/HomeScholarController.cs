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

    public class HomeScholarController : Controller
    {
        [HttpGet]
        public IEnumerable<HomeScholar> Get()
        {
            HomeScholar[] homeScholars = null;
            using (var context = new ApplicationDbContext())
            {
                //homeScholars = context.HomeScholars.ToArray();
            }
            return homeScholars;

        }

        [HttpPost]
        public HomeScholar Post([FromBody]HomeScholar homeScholar)
        {
            using (var context = new ApplicationDbContext())
            {
                //context.HomeScholars.Add(homeScholar);
                context.SaveChanges();
            }
            return homeScholar;
        }
    }
}