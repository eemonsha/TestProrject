using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;
using TestProrject.ViewModel;

namespace TestProrject.Controllers
{
    public class StudentsController : Controller
    {

        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IWebHostEnvironment webHostEnvironment;

        public StudentsController(DataContext context, IToastNotification toastNotification , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _toastNotification = toastNotification;
            webHostEnvironment = hostEnvironment;

        }
        public IActionResult StudentIndex()
        {
            var stulist = _context.Students.ToList();
            var viewmodel = new List<StudentVM>();
            var model = new StudentVM();

            foreach (var item in stulist)
            {
                model = new StudentVM
                {
                    StudentID = item.StudentID,
                    StudentName = item.StudentName,
                    StudentIDentity = item.StudentIDentity,
                    StudentScore = item.StudentScore,
                    StudentPicture = item.PPicture
                };
                viewmodel.Add(model);
            }
            return View(viewmodel);
        }



    

        public IActionResult StudentShow()
        {
            var stu = from st in _context.Students
                      join dep in _context.Departments
                      on st.DepID equals dep.DepartmentID
                      select new StudentVM
                      {

                          StudentID = st.StudentID,
                          StudentName = st.StudentName,
                          StudentIDentity = st.StudentIDentity,
                          StudentScore = st.StudentScore,
                          StudentPicture = st.PPicture,
                          DepartmentName = dep.DepartmentName

                      };
            return View(stu);
        }


        //Search implement with store Procedure
        public async Task<IActionResult> StudentSearch(int min, int max)
        {
         
            if (min >= 0 && max > 0)
            {
                if(min > max)
                {
                    ViewBag.msg = " Maximum score must be gether then minimum score. ";
                    return View();
                }

                //connection store procedure
                using(var conn= _context.Database.GetDbConnection())
                {
                    await conn.OpenAsync();
                    using(var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "getstudent"; //name of store procedure
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        //parameter passs
                        DbParameter p1 = cmd.CreateParameter();
                        p1.ParameterName = "@minscore";//store procedure variable name
                        p1.Value = min; //Action variable name
                        p1.DbType = System.Data.DbType.Int32;
                        p1.Direction = System.Data.ParameterDirection.Input;

                        //parameter passs
                        DbParameter p2 = cmd.CreateParameter();
                        p2.ParameterName = "@maxscore";//store procedure variable name
                        p2.Value = max; //Action variable name
                        p2.DbType = System.Data.DbType.Int32;
                        p2.Direction = System.Data.ParameterDirection.Input;

                        cmd.Parameters.Add(p1);//parameter add
                        cmd.Parameters.Add(p2);//parameter add

                        DbDataReader dr = cmd.ExecuteReader();//one time read data

                        if (dr.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);//data load in this table 
                            _toastNotification.AddSuccessToastMessage("Here Is the DATA");
                            return View(dt); 
                            
                        }
                        else
                        {
                            //ViewBag.msg = "No Data Found";
                            _toastNotification.AddSuccessToastMessage("No Data Found");
                            return View();
                        }


                    }

                }
            }
            else
            {
                ViewBag.msg = "Min or Max Score must be provided ";
                //_toastNotification.AddSuccessToastMessage("Min or Max Acore must be provided or grether then ZERO");
                return View();
            }
           

            
        }

        





        public IActionResult StudentCreate()
        {

            DfaultData();



            var NewStudent = new StudentVM();
            NewStudent.Balance = 0;
            NewStudent.StudentScore = 0;
            return View(NewStudent);
        }

        private void DfaultData()
        {


            IEnumerable<SelectListItem> dep = from Department in _context.Departments.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Department.DepartmentID.ToString(),
                                                  Text = Department.DepartmentName
                                              };
            ViewBag.deepart = dep;
        }


        [HttpPost]
        public IActionResult StudentCreate(StudentVM student)
        {

            DfaultData();

            var stuCode = _context.Students.Where(x => x.StudentIDentity == student.StudentIDentity).FirstOrDefault();

                if (stuCode == null)
                {
                    string uniqueFileName = UploadedFile(student);
                    var stdnt = new Student();

                    stdnt.StudentName = student.StudentName;
                    stdnt.StudentIDentity = student.StudentIDentity;
                    stdnt.DepID = student.DepID;
                    stdnt.Balance = student.Balance;
                    //stdnt.RemainBalance = stdnt.Balance;
                    stdnt.RemainBalance = student.RemainBalance;
                    stdnt.StudentScore = student.StudentScore;
                    stdnt.ISActive = student.ISActive;
                    stdnt.StudentStatus = student.StudentStatus = "NEW";
                    stdnt.PPicture = uniqueFileName;


                var depid = _context.Departments.Where(x => x.DepartmentID != student.DepartmentID).FirstOrDefault();
                var depscore = depid.DepartmentScore;
                if (depscore <= student.StudentScore)
                {

                    _context.Students.Add(stdnt);
                    _context.SaveChanges();
                    _toastNotification.AddSuccessToastMessage("Student Added");
                    return RedirectToAction("StudentIndex");

                }
                else
                {
                    var dpid = _context.Departments.Where(x => x.DepartmentID != student.DepartmentID).FirstOrDefault();
                    var dpscore = depid.DepartmentScore;
                    TempData["mg"] = depid.DepartmentName + " department minimum score needed: " + depscore ;
                    
                }
                }
             
               
                else
                {
                    TempData["msg"] = "Student ID Alrdy Exist";
                  
            }

            


            
            return View();
        }


        public IActionResult Studentdetails(int id)
        {
            var sql = (from student in _context.Students.Where(x => x.StudentID == id)
                       join dep in _context.Departments
                       on student.DepID equals dep.DepartmentID
                       select new StudentVM
                       {
                           StudentName = student.StudentName,
                           StudentIDentity = student.StudentIDentity,
                           Balance = student.Balance,
                           RemainBalance = student.RemainBalance,
                           StudentScore = student.StudentScore,
                           StudentStatus = student.StudentStatus,
                           StudentPicture = student.PPicture,
                           DepartmentID = dep.DepartmentID,
                           DepartmentName = dep.DepartmentName,


                       }).FirstOrDefault();
                       

            return View(sql);
        }


        public IActionResult PAymentIndex()
        {
            var paylist = _context.PaymentRecharges.ToList();
            return View(paylist);
        }

        public IActionResult PaymentRecharge()
        {
            DefaultData();
            var payrcrg = new PaymentRecharge();
            payrcrg.PaymentAmount = 0;
            payrcrg.PaymentDate = System.DateTime.Now;

            return View();
        }


        private void DefaultData()
        {
            
            

            IEnumerable<SelectListItem> stu = from Student in _context.Students.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Student.StudentID.ToString(),
                                                  Text = Student.StudentIDentity + "_" + Student.StudentName
                                              };
            ViewBag.stu = stu;
        }

        [HttpPost]
        public IActionResult PaymentRecharge(PaymentRecharge paymentRecharge)
        {
            if (paymentRecharge.PStudentID == 0)
            {
                _toastNotification.AddErrorToastMessage("Please specify Student");
                DefaultData();//loading default data
                return View(paymentRecharge);
            }

            var tk = _context.Students.Where(x => x.StudentID == paymentRecharge.PStudentID).FirstOrDefault();
            tk.RemainBalance = tk.RemainBalance + paymentRecharge.PaymentAmount;
            _context.Update(tk);
            _context.SaveChanges();

            _context.PaymentRecharges.Add(paymentRecharge);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Payment Added");

            return RedirectToAction("PAymentIndex");
        }

        public JsonResult GetStudentAmount(int stuid)
        {

            var rmnamn = _context.Students.FirstOrDefault(x => x.StudentID == stuid).RemainBalance;
            return Json(rmnamn);


        }

        //public JsonResult Getdepscore(int depid)
        //{
        //    var score = _context.Departments.FirstOrDefault(x => x.DepartmentID == depid).DepartmentScore;
        //    return Json(score);
        //}

        //public JsonResult Getdepscore(decimal depscore)
        //{
        //    var score = _context.Departments.FirstOrDefault(x => x.DepartmentScore == depid).DepartmentScore;
        //    return Json(score);
        //}
        private string UploadedFile(StudentVM model)
        {
            string uniqueFileName = null;

            if (model.StudentImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/Student");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.StudentImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.StudentImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
