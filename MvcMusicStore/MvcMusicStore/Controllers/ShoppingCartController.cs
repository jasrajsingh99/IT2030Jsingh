using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        MusicStoreDB db = new MusicStoreDB(); 
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(HttpContext);

            ShoppingCartViewModel vm = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetCartTotal()
            };

            return View(vm);
        }

        // Get: ShoppingCart/AddToCart
        public ActionResult AddToCart(int id )
        {
            //ShoppingCart cart = new ShoppingCart();
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("Index");

            throw new NotImplementedException();
        }

        // Post: ShoppingCart/RemoveFromCart
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            Album album = db.Carts.SingleOrDefault(c => c.RecordId == id).AlbumSelected;
            int newItemCount = cart.RemoveFromCart(id);
            cart.RemoveFromCart(id);


            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
               DeleteId = id,
               CartTotal = cart.GetCartTotal(),
               ItemCount = newItemCount,
               Message = album.Title + " has been removed from the cart"
            };
            return Json(vm);
        }
    }
}