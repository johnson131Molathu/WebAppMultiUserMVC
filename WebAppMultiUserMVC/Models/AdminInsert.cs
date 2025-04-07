using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMultiUserMVC.Models
{
    public class AdminInsert
    {
        [Required(ErrorMessage = "Enter the Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Enter the Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Enter the Phone")]
        [RegularExpression(@"^(\d{10})$",ErrorMessage ="Enter valid number")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Enter valid id")]
        public string email { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        [Compare("pass",ErrorMessage ="Password mismatch")]
        public string cpassword { get; set; }
        public string adminmsg { get; set; }



    }
}