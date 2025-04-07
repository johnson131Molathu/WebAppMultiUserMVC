using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMultiUserMVC.Models
{
    public class UserInsert
    {
        [Required(ErrorMessage = "Enter the Name")]
        public string name { get; set; }
        [Range(18, 50, ErrorMessage = "Enter the Age")]
        public int age { get; set; }        
        [Required(ErrorMessage = "Enter the Address")]
        public string address { get; set; }
       
        [Required(ErrorMessage = "Enter valid id")]
        public string email { get; set; }
        public string photo { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        [Compare("pass", ErrorMessage = "Password mismatch")]
        public string cpassword { get; set; }
        public string usermsg { get; set; }

    }
}