using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStoreApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;

        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        private string GetCartId(HttpContextBase context)
        {
            const string CartSessionId = "CartId";

            string cartId;
            
            if (context.Session[CartSessionId] == null)
            {
                //create new cart Id
                cartId = Guid.NewGuid().ToString();

                //save to session date.
                context.Session[CartSessionId] = cartId;
            }
            else
            {
                //return the existing CartId
                cartId = context.Session[CartSessionId].ToString(); 

            }

            return cartId;
        }

        public List<Cart> GetCartItems()
        {

            return db.Carts.Where(c => c.CartId == this.ShoppingCartId).ToList();
            
        }

        public decimal GetCartTotal()
        {
            //(int ?) makes it nullable
            decimal? total = (from cartItem in db.Carts
                        where cartItem.CartId == this.ShoppingCartId
                        select cartItem.AlbumSelected.Price * (int?)cartItem.Count).Sum();
            
           //if (total.HasValue)
           //{
           //    return total.Value;
           //}
           //else
           //{
           //    return decimal.Zero;
           //}

            return total.HasValue ? total.Value : decimal.Zero;

            //return total ?? decimal.Zero;
        }
        public void AddToCart(int albumId)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.AlbumId == albumId);

            if (cartItem == null)
            {
                //Item is not in shopping cart; add new item
                cartItem = new Cart()
                {
                    CartId = this.ShoppingCartId,
                    AlbumId = albumId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                db.Carts.Add(cartItem);

            }
            else
            {
                //Item is already in cart; increase item count (Quantity)
                //cartItem.Count = cartItem.Count + 1;
                cartItem.Count++;

            }

            db.SaveChanges();
        }
            public int RemoveFromCart(int recordId)
        {
            //Ctrl + Shift + V
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.RecordId == recordId);
            if (cartItem == null)
            {


                throw new NullReferenceException();
            }
            int newCount;

            if (cartItem.Count > 1)
            {
                //count is > 1; decrement the count
                cartItem.Count--;
                newCount = cartItem.Count;
               
            }
            else
            {
                //if count is at 0; remove cart item
                db.Carts.Remove(cartItem);
                newCount = 0;

            }

            db.SaveChanges();

            return newCount;
        }
    }
}

   