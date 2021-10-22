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

            try
            {
                item.GetVendingItems();
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void ShowVendingItemsTest()
        {
            LoadingItems item = new LoadingItems();

            try
            {
                item.ShowVendingItems();
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }
    }
}
