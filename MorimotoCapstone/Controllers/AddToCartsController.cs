using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;


namespace MorimotoCapstone.Controllers
{
    public class AddToCartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddToCartsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: AddToCartsController
        public IActionResult Add(Product product, int count)
        {
            List<Product> products = new List<Product>();
            products.Add(product);
            ViewBag.shoppingCart = products.Count();
            count = 1;
            return RedirectToAction("Index", "Home");
        }

        // GET: AddToCartsController/Details/5
        public ActionResult MyOrder()
        {
            return View("shoppingCart");
        }

       
    }
}
