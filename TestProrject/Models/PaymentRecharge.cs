using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProrject.Models
{
    public class PaymentRecharge
    {
        [Key]
        public int PaymentRID { get; set; }

        [Required]
        public decimal PaymentAmount { get; set; }

        [Required]
        public int PStudentID { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }


    }
}
