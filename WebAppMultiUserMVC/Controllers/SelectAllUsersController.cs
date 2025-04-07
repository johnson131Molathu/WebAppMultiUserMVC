using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMultiUserMVC.Controllers
{
    public class SelectAllUsersController : Controller
    {
        Entities dbobj = new Entities();
        // GET: SelectAllUsers
        public ActionResult DisplayAll_SP_Load()
        {
            var data = dbobj.sp_selectallusers().ToList();
            ViewBag.userdetails = data;
            return View();
        }
    }
}