using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProrject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(10)]
        public String DepartmentName { get; set; }


        public decimal DepartmentScore { get; set; }
        public decimal DepartmentCreditPrice { get; set; }
    }
}
