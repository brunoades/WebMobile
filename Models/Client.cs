using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMobile.Models
{
	public class Client
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Cnpj { get; set; }
    }
}