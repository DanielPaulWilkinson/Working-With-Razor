using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithRazor.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set;  }
        public string Desc { get; set; }
        public decimal price { get; set; }
        public string Category { get; set; }
    }
}
