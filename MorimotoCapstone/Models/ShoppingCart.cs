using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MorimotoCapstone.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Models
{
    public class ShoppingCart
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";

        public static ShoppingCart GetCart(HttpContext context)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddToCart(Product product)
        {
            var cartItem = dbContext.Carts.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.ProductId == product.ProductId);
            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    ProductId = product.ProductId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                dbContext.Carts.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            dbContext.SaveChanges();
        }

        public int RemoveFromCart(int id)
        {
            var cartItem = dbContext.Carts.Single(
                cart => cart.CartId == ShoppingCartId
                && cart.ProductId == id);

            int itemCount = 0;
            if(cartItem != null)
            {
                if(cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    dbContext.Carts.Remove(cartItem);
                }
                dbContext.SaveChanges();
            }
            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = dbContext.Carts.Where(
                cart => cart.CartId == ShoppingCartId);

            foreach(var cartItem in cartItems)
            {
                dbContext.Carts.Remove(cartItem);
            }
            dbContext.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return dbContext.Carts.Where(
                cart => cart.CartId == ShoppingCartId).ToList();
        }

        public int GetCount()
        {
            int count = (int)(from cartItems in dbContext.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();
            return count;
        }

        public double GetTotal()
        {
            double total = (double)(from cartItems in dbContext.Carts
                              where cartItems.CartId == ShoppingCartId
                              select (int?)cartItems.Count *
                              cartItems.Product.ProductPrice).Sum();
            return total;
        }

        public int CreateOrder(ServiceInstallOrder serviceInstallOrder)
        {
            double orderTotal = 0;

            var cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                var serviceOrderDetail = new ServiceOrderDetail
                {
                    ProductId = item.ProductId,
                    OrderId = serviceInstallOrder.OrderId,
                    ProductPrice = item.Product.ProductPrice,
                    Quantity = item.Count
                };
                orderTotal += (item.Count * item.Product.ProductPrice);

                dbContext.ServiceOrderDetails.Add(serviceOrderDetail);
            }
            serviceInstallOrder.Total = orderTotal;

            dbContext.SaveChanges();
            EmptyCart();
            return serviceInstallOrder.OrderId;
        }

        public string GetCartId(HttpContext context)
        {
            if (context.Session.GetString(CartSessionKey) == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session.SetString(CartSessionKey, context.User.Identity.Name);
                }
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    context.Session.SetString(CartSessionKey, tempCartId.ToString());
                }
            }
            return context.Session.GetString(CartSessionKey);
        }    
        
        public void MigrateCart(string userName)
        {
            var shoppingCart = dbContext.Carts.Where(
                c => c.CartId == ShoppingCartId);
            foreach(Cart item in shoppingCart)
            {
                item.CartId = userName;
            }
            dbContext.SaveChanges();
        }
    }
}
