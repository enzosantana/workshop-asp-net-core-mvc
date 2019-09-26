using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        // Dependency injection
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            //Find All returns a list with all the sellers
            var list = _sellerService.FindAll();

            //Controller - Index => Controller access Model and retrieves data (var list) => Controller sends data to View (View(list)
            return View(list);
        }
    }
}