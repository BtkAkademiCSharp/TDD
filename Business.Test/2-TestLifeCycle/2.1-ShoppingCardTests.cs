using Business.ShoppingCard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class ShoppingCardTests
    {
        private CartItem _cartItem;
        private CartManager _cartManager;
        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void AddItemToBasket()
        {
            //Arrange
            const int expected = 1;

            //Act
            int totalItem = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(expected, totalItem);
        }
        [TestMethod]
        public void RemoveItemFromBasket()
        {
            //Arrange
            int totalItemBeforeDel = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            int totalItemAfterDel = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(totalItemBeforeDel - 1, totalItemAfterDel);
        }
        [TestMethod]
        public void ClearBasket()
        {
            //Act
            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }
    }
}
