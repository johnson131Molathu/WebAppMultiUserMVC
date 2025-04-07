using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMultiUserMVC.Controllers
{
    public class SelectUserController : Controller
    {
        Entities dbobj = new Entities();
        // GET: SelectUser
        public ActionResult User_Load()
        {

            var data = dbobj.sp_selectusers().ToList();
            ViewBag.userdetails = data;
            return View();
        }
    }
}