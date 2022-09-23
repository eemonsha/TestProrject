using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProrject.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Required]
        [StringLength(10)]
        public String CourseCode { get; set; }

        [Required]
        [StringLength(30)]
        public String CourseName { get; set; }

        [Required]
        public int Coursecredit { get; set; }

        [Required]
        public decimal CoursecreditPrice { get; set; }
    }
}
