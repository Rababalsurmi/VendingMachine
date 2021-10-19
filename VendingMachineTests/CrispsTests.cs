using System;
using Xunit;
using VendingMachine.Model;

namespace VendingMachineTests
{
    public class CrispsTests
    {
        [Fact]
        public void CrispsTest()
        {
            string productName = "Pringels Sour Cream & Onion Chip";
            decimal price = 4.50M;
            int remainingitems = 10;
            //string Message = "Munching Crisps .... Yum! ";


            Crisps item = new Crisps(productName, price, remainingitems);

            Assert.Equal(item.ProductName, productName);
            Assert.Equal(item.Price, price);
            Assert.Equal(item.RemainingItems, remainingitems);
        }
    }
}
