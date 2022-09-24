using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProrject.ViewModel
{
    public class StudentVM
    {


        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public String StudentIDentity { get; set; }
        public int DepID { get; set; }
        public decimal Balance { get; set; }
        public decimal RemainBalance { get; set; }
        //public String PPicture { get; set; }
        public bool ISActive { get; set; }
        public int StudentScore { get; set; }
        public String StudentStatus { get; set; }


        //Image Add
        public IFormFile StudentImage { get; set; }

        public bool DeleteStu { get; set; }
    }
}
