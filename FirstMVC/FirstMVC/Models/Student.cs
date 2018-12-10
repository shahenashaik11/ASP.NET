using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
       //public Course course = new Course();
        
    }
}