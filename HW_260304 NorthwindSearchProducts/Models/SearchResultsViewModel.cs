using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_260304_NorthwindSearchProducts.Models
{
    public class SearchResultsViewModel
    {
        public List<Product> Products { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
    }
}