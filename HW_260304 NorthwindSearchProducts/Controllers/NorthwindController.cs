using HW_260304_NorthwindSearchProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_260304_NorthwindSearchProducts.Controllers
{
    public class NorthwindController : Controller
    {
        // GET: Northwind
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchProducts()
        {
            return View();
        }

        public ActionResult SearchResults(int searchMinStock = 1, int searchMaxStock = 100)
        {
            NorthwindDbManager manager = new NorthwindDbManager(Properties.Settings.Default.ConStr);
            SearchResultsViewModel viewModel = new SearchResultsViewModel
            {
                Products = manager.SearchProducts(searchMinStock, searchMaxStock),
                MinStock = searchMinStock,
                MaxStock = searchMaxStock
            };
            return View(viewModel);
        }        
    }
}