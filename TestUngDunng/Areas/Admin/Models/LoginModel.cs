using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestUngDunng.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}