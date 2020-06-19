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
    public class ShoppingCardTests2
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
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
        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void When_different_item_add_to_basket_then_total_item_increment_one()
        {
            //Arrange
            int totalItem = _cartManager.TotalItems;
            int totalQuantity = _cartManager.TotalQuantity;

            //Act
            _cartManager.Add(new CartItem
            {
                Product=new Product
                {
                    ProductId=2,
                    ProductName="Mouse",
                    UnitPrice=10
                },
                Quantity=1
            });

            //Assert
            Assert.AreEqual(totalQuantity + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalItem + 1, _cartManager.TotalItems);
        }
        [TestMethod]
        public void When_same_item_add_to_basket_then_total_quantity_increment_one_and_total_item_should_stay_same()
        {
            //Arrange
            int totalItem = _cartManager.TotalItems;
            int totalQuantity = _cartManager.TotalQuantity;

            //Act
            _cartManager.Add(_cartItem);

            //Assert
            Assert.AreEqual(totalQuantity + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalItem, _cartManager.TotalItems);
        }
    }
}
