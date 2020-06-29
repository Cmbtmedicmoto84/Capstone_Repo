using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Data;
using MorimotoCapstone.Helpers;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class ShoppingCartsController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public ShoppingCartsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        // GET: ShoppingCarts
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "shoppingCart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.ProductPrice * item.Quantity);
            return View();
        }

        // GET: ShoppingCarts/Details/5
        public IActionResult Buy(int id)
        {
            Product product = new Product();
            if(SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = product.find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != 1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = product.find(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        //public IActionResult Remove(int id)
        //{
        //    List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
        //    for (int i = 0; i < cart.Count; i++)
        //    {
        //        if (cart[i].Product.Id.Equals(id))
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        //private bool ShoppingCartExists(int id)
        //{
        //    return _context.ShoppingCarts.Any(e => e.CartId == id);
        //}

        private class Item
        {
            public object Product { get; set; }
            public int Quantity { get; set; }
            public decimal ProductPrice { get; set; }

        }
    }
}
