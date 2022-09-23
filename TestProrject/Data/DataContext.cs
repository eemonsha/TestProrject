using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Models;

namespace TestProrject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }

        public DbSet<Sales> Sales { get; set; }


        public DbSet<SalesProduct> SalesProducts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<QRs> QRs {get; set; }
        public DbSet<Supplier> Suppliers {get; set; }



        public DbSet<Department> Departments {get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<PaymentRecharge> PaymentRecharges {get; set; }
        public DbSet<Student> Students {get; set; }
    }
}
