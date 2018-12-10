using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
           
           
            //student.Id = 10;
            //student.Name = "SHONU";
            //student.course.CourseId = 1;
            //student.course.CourseName = "Java";
            var model = new List<Student>();
            string con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Student", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.Name = Convert.ToString(rdr["Name"]);
                    
            

                    model.Add(student);
                }

            }

            return View(model);
        }
          
           
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}