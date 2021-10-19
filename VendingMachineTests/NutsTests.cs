using System;
using Xunit;
using VendingMachine.Model;

namespace VendingMachineTests
{
    public class NutsTests
    {
        [Fact]
        public void NutsTest()
        {
            string productName = "Cashew Nuts";
            decimal price = 3.50M;
            int remainingitems = 7;
            //string Message = "Nuts Munching... Yum! ";


            Nuts item = new Nuts(productName, price, remainingitems);

            Assert.Equal(item.ProductName, productName);
            Assert.Equal(item.Price, price);
            Assert.Equal(item.RemainingItems, remainingitems);
        }
    }
}
