using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_260304_NorthwindSearchProducts.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}