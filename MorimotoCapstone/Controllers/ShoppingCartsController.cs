using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class ShoppingCartsController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            return View(viewModel);
        }

        public ActionResult AddToCart(int id)
        {
            var addedProduct = dbContext.Products
                .Single(product => product.ProductId == id);

            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(addedProduct);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            string productName = dbContext.Products
                .Single(item => item.ProductId == id).ProductName;

            int itemCount = cart.RemoveFromCart(id);

            var results = new ShoppingCartRemoveViewModel
            {
                Message = (productName) +
                    "has been removed from your cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        //[ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}
