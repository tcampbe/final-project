using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace capstone.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool Resource { get; set; }
        public bool PreSchool { get; set; }
        public bool Elementary { get; set; }
        public bool MiddleSchool { get; set; }
        public bool HighSchool { get; set; }
        public bool HigherEducation { get; set; }
        public string WebSite { get; set; }
    }
}
