using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseWeb.Models
{
    public class DbConnection :DbContext
    {
        public DbConnection() : base()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}