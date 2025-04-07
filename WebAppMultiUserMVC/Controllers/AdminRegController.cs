using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMultiUserMVC.Models;
using System.Data.SqlClient;
using System.Data;


namespace WebAppMultiUserMVC.Controllers
{
    public class AdminRegController : Controller
    {
        Entities dbobj = new Entities();

        // WebAppMultiUserMVC obj = new WebAppMultiUserMVC();
        // GET: AdminReg
        public ActionResult Insert_AdminPageload()
        {
            return View();
        }
        public ActionResult Insertadmin_Click(AdminInsert clsobj)
        {
            if(ModelState.IsValid)
            {
                var getmaxid = dbobj.sp_MaxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if(mid==0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                dbobj.sp_adminregtab(regid, clsobj.name, clsobj.address, clsobj.phone, clsobj.email);
                dbobj.sp_logininsert(regid, clsobj.username, clsobj.pass, "admin");
                clsobj.adminmsg = "success";
                return View("Insert_AdminPageload",clsobj);
            }
            else
            {
                return View("Insert_AdminPageload",clsobj);
            }
            
        }
    }
}