using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWeb.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DateOfBath { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Student Student { get; set; }
        public Lecturers lectures { get; set; }

    }
    public class LoginModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }

    public class Student
    {
        public int StID { get; set; }
        public int CourseID { get; set; }
        public string DateOfJoin { get; set; }
    }
    public class Lecturers
    {
        public int LecID { get; set; }
        public int CourseID { get; set; }
        public double Salary { get; set; }
        public string Subject { get; set; }
    } 
}