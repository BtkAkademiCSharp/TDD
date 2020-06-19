using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ShoppingCard
{
    public class CartManager
    {
        private readonly List<CartItem> _cartItems;
        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }
        public void Add(CartItem cartItem)
        {
            var addedCartItem = _cartItems.SingleOrDefault(p => p.Product.ProductId == cartItem.Product.ProductId);
            if (addedCartItem != null)
            {
                addedCartItem.Quantity += cartItem.Quantity;
            }
            else
                _cartItems.Add(cartItem);
        }
        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(x => x.Product.ProductId == productId);
            _cartItems.Remove(product);
        }
        public List<CartItem> CartItems { get => _cartItems; }
        public void Clear() => _cartItems.Clear();
        public decimal TotalPrice { get => _cartItems.Sum(x => x.Product.UnitPrice * x.Quantity); }
        public int TotalQuantity => _cartItems.Sum(x => x.Quantity);
        public int TotalItems => _cartItems.Count;
    }
}
