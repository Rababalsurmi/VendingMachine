using System;
using Xunit;
using VendingMachine.Model;

namespace VendingMachineTests
{
    public class ChocolateTests
    {
        [Fact]
        public void ChocolateTest()
        {
            string productName = "Kit-Kat";
            decimal price = 1.50M;
            int remainingitems = 5;
            //string Message = "Chocolate Munching... Yum! ";


            Chocolate item = new Chocolate(productName, price, remainingitems);

            Assert.Equal(item.ProductName, productName);
            Assert.Equal(item.Price, price);
            Assert.Equal(item.RemainingItems, remainingitems);
        }
    }
}
