using System;
using Xunit;
using System.Collections.Generic;
using VendingMachine.Model;

namespace VendingMachineTests
{
    public class LoadingItemsTests
    {
        [Fact]
        public void GetVendingItemsTest()
        {

            LoadingItems item = new LoadingItems();

            Dictionary<string, ProductItem> actual =  item.GetVendingItems();

            Assert.NotEmpty (actual);
            
        }
    }
}
