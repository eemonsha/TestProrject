using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProrject.Models
{
    public class Student
    {

        


        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(30)]
        public String StudentName { get; set; }

        [Required]
        [StringLength(15)]
        public String StudentIDentity { get; set; }

        [Required]
        public int DepID { get; set; }

        public decimal Balance { get; set; }
        public decimal RemainBalance { get; set; }
        public String PPicture { get; set; }
        public bool ISApproved { get; set; }
        public int StudentScore { get; set; }

        [Required]
        public String StudentStatus { get; set; }
    }
}
