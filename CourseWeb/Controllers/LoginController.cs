using CourseWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CourseWeb.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                string hashPassword = getHashPassword(model.PassWord);
                Console.WriteLine(hashPassword);
            }
            else
            {
                return Content("UserName Or Password Not a valide input");
            }
            return View();
        }

        public ActionResult LoginAction()
        {
            return View();
        }


        private static string getHashPassword(string textPassword)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(textPassword));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}