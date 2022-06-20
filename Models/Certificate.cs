using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMobile.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public int Client_Id { get; set; }
        public string Md5sum { get; set; }
        public string Password { get; set; }
    }
}