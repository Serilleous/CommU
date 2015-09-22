using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommU.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public String Owner { get; set; }
        public bool IsAwesome { get; set; }
    }
}