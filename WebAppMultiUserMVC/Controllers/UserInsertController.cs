using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMultiUserMVC.Models;
using System.Data.SqlClient;
using System.Data;


namespace WebAppMultiUserMVC.Controllers
{
    public class UserInsertController : Controller
    {
        // GET: UserInsert
        Entities dbobj = new Entities();

        // WebAppMultiUserMVC obj = new WebAppMultiUserMVC();
        // GET: AdminReg
        public ActionResult User_Pageload()
        {

            return View();
        }
        public ActionResult Insertuser_Click(UserInsert clsobj,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {//folder save
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/PHS/");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    //for table save
                    var fullpath = Path.Combine("~/PHS/", fname);
                    clsobj.photo = fullpath;//set
                }
                var getmaxid = dbobj.sp_MaxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                dbobj.sp_userReg(regid, clsobj.name,clsobj.age, clsobj.address,clsobj.email,clsobj.photo);
                dbobj.sp_logininsert(regid, clsobj.username, clsobj.pass, "user");
                clsobj.usermsg = "success";
                return View("User_Pageload",clsobj);
            }
            else
            {
                return View("User_Pageload",clsobj);
            }

        }       
    }
}