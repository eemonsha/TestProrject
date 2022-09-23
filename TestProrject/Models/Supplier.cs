using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProrject.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public String SupplierNAme { get; set; }
        public String SupplierAddress { get; set; }
        public String SNMbr { get; set; }
       

    }
}
