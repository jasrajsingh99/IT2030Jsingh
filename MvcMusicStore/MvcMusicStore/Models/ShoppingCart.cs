using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;

        private MusicStoreDB db = new MusicStoreDB();

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
                //create new cartID
                cartId = Guid.NewGuid().ToString();
                //save to session date
                context.Session[CartSessionId] = cartId;
            }
            else
            {
                //return existing cart 
               cartId =  context.Session[CartSessionId].ToString();
            }


            return cartId;
        }
        public List<Cart> GetCartItems()
        {
            //ToList because view expects a list
            return db.Carts.Where(c => c.CartId == this.ShoppingCartId).ToList();
        }

        public decimal GetCartTotal()
        {
            decimal? total = (from CartItem in db.Carts
                        where CartItem.CartId == this.ShoppingCartId
                        select CartItem.AlbumSelected.Price * (int?)CartItem.Count).Sum();


            //if (total.HasValue)
            //{
            //    return total.Value;
            //}
            //else
            //{
            //    return decimal.Zero;
            //}

            //return total.HasValue ? total.Value : decimal.Zero;

            return total ?? decimal.Zero;
        }
        public void AddToCart(int albumId)
        {
            //TODO:  Verify that the albumId exists in the database
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.AlbumId == albumId);
            
            if (cartItem == null)
            {
                //item is not in shopping cart, add brand new item 
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
                //if item is, increase item count
                cartItem.Count++;
            }
            db.SaveChanges();


            throw new NotImplementedException();
        } 

          
        public int RemoveFromCart(int recordId)
        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.ShoppingCartId && c.RecordId == recordId);
            if(cartItem == null)
            {
                throw new NullReferenceException();
            }

            int newCount;
            if (cartItem.Count > 1)
            {
                //the count is greater than 1; decrement count
                cartItem.Count--;
                newCount = cartItem.Count;
            }
            else
            {
                //the count is zero; remove cart item
                db.Carts.Remove(cartItem);
                newCount = 0;
            }
            db.SaveChanges();

            return newCount;

        }
    }
    
}