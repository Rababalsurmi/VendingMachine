using System;
using Xunit;
using VendingMachine.Model;

namespace VendingMachineTests
{
    public class MoneyTests
    {
        [Fact]
        public void InsertMoneyTest()
        {
            string amount = "100";
            MoneyTracker track = new MoneyTracker();
            bool expected = true;


            Money money = new Money(track); ;
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

            Money money = new Money(track); ;
            string actual = money.EndTransaction( amountToRemove, MoneyInMachine);

            Assert.Equal(result, actual);
        }
    }
}
