using System;
using Xunit;
using VendingMachine.Model;
using System.Collections.Generic;

namespace VendingMachineTests
{
    public class VendingMachineTests
    {
        [Fact]
        public void InsertMoneyTest()
        {
            string amount = "100";
            MoneyTracker track = new MoneyTracker();
            bool expected = true;


            MethodsVendingMachine money = new MethodsVendingMachine(track); ;
            bool actual = money.InsertMoney(amount);

            Assert.Equal(expected, actual);
         }

        [Fact]
        public void EndTransactionTest()
        {
            string result = $"Your change is "+ "450";
            MoneyTracker track = new MoneyTracker();
            decimal amountToRemove = 50M;
            decimal MoneyInMachine = 500M;

            MethodsVendingMachine money = new MethodsVendingMachine(track); ;
            string actual = money.EndTransaction( amountToRemove, MoneyInMachine);

            Assert.Equal(result, actual);
        }

        [Fact]
        public void PurchaseTest()
        {
            bool result = false;
            string itemNumber = "M1";


            MoneyTracker track = new MoneyTracker();
            
            MethodsVendingMachine money = new MethodsVendingMachine(track); ;
            bool actual = money.Purchase(itemNumber);

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ShowAllTest()
        {
            MethodsVendingMachine showItems = new MethodsVendingMachine();
            try
            {
                showItems.ShowAll();
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void ExamineTest()
        {
            MethodsVendingMachine showItems = new MethodsVendingMachine();
            try
            {
                showItems.Examine();
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void ItemExistsTest()
        {
            MethodsVendingMachine showItems = new MethodsVendingMachine();
            string itemNumber = "A1";
            try
            {
                showItems.ItemExists(itemNumber);
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void UseTest()
        {
            MethodsVendingMachine showItems = new MethodsVendingMachine();
            string choice = "A1";
            try
            {
                showItems.Use(choice);
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }
    }
}
