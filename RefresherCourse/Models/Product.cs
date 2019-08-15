using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RefresherCourse.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public string Fuel { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }
    }
}