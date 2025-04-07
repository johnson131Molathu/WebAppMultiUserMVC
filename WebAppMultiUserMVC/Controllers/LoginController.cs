using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMultiUserMVC.Models;

namespace WebAppMultiUserMVC.Controllers
{
    public class LoginController : Controller
    {
        Entities dbobj = new Entities();
        // GET: Login
        public ActionResult Login_Pageload()
        {
            return View();
        }
        public ActionResult UserHome()
        {
            return View();
        }
        public ActionResult AdminHome()
        {
            return View();

        }
        public ActionResult Login_Click(Login objcls)
        {
            if (ModelState.IsValid)
            {
                var val = dbobj.sp_loginCountId(objcls.Uname, objcls.Password).First();
                if (val == 1)
                {
                    var uid = dbobj.sp_loginId(objcls.Uname, objcls.Password).FirstOrDefault();
                    Session["uid"] = uid;
                    var lt = dbobj.sp_loginType(objcls.Uname, objcls.Password).FirstOrDefault();
                    if (lt == "user")
                    {
                        return RedirectToAction("UserHome");
                    }
                    else if (lt == "admin")
                    {
                        return RedirectToAction("AdminHome");
                    }

                }
            }
            else
            {
                ModelState.Clear();
                objcls.msg = "Invalid Login";
                return View("Login_Pageload", objcls);
            }
            return View("Login_Pageload", objcls);
        }

    }
}