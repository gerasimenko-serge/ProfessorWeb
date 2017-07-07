using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfessorWeb.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}