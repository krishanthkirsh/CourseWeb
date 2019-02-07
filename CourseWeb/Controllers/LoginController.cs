using CourseWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}