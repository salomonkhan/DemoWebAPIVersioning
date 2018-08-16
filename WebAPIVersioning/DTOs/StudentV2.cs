using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIVersioning.DTOs
{
    public class StudentV2
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}