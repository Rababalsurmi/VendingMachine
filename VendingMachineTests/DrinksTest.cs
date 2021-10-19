using System;
using Xunit;
using VendingMachine.Model;

namespace VendingMachineTests
{
    public class DrinksTest
    {
        [Fact]
        public void DrinksTests()
        {
            string productName = "Sprite";
            decimal price = 2;
            int remainingitems = 5;
            //string Message = "Drinking... Yum! ";


            Drinks item = new Drinks(productName, price, remainingitems);
          
            Assert.Equal(item.ProductName, productName);
            Assert.Equal(item.Price, price);
            Assert.Equal(item.RemainingItems, remainingitems);
        }
    }
}
