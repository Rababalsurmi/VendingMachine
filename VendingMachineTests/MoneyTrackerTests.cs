using System;
using Xunit;
using VendingMachine.Model;
using System.Collections.Generic;

namespace VendingMachineTests
{
    public class MoneyTrackerTests
    {
        [Fact]
        public void TrackTest()
        {
            MoneyTracker tracker = new MoneyTracker();
            string message = "Money in Machine:";
            decimal moneyBefore = 10.0M;
            decimal moneyAfter = 9.50M;
            try
            {
                tracker.Track(message, moneyBefore, moneyAfter);
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }
    }
}
