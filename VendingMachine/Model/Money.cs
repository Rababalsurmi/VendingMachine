using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public class Money : IVending
    {
        private MoneyTracker track;

        public decimal MoneyInMachine { get; private set; }


        public Money(MoneyTracker track)
        {
            MoneyInMachine = 0M;
            this.track = track;
        }

        public bool InsertMoney (string amount)
        {

            if (!decimal.TryParse(amount, out decimal amountInserted))
            {
                amountInserted = 0M;
                return false;
            }

            string message = $"INSERT MONEY: ";

            decimal before = MoneyInMachine;

            MoneyInMachine += amountInserted;

            decimal after = MoneyInMachine;

            //to track the money using MoneyTracker class
            this.track.Track(message, before, after);

            return true;
        }

        public string EndTransaction()
        {
            string result = string.Empty;
            decimal amountToRemove = 0M;

            string message = $"End Transaction: ";

            //To track money pool before transaction
            decimal before = MoneyInMachine;

            if(MoneyInMachine > 0 )
            {
                MoneyInMachine -= amountToRemove;

                result = $"Your change is ";
                result += $"{MoneyInMachine}";

                //To track money pool after transaction
                decimal after = MoneyInMachine;

                //Tracking current money
                track.Track(message, before, after);
            }
            else
            {
                result = "No money to return";
            }

            return result;
        }

        public string EndTransaction(decimal amountToRemove, decimal MoneyInMachine)
        {
            string result = string.Empty;
            //amountToRemove = 0M;

            string message = $"End Transaction: ";

            //To track money pool before transaction
            decimal before = MoneyInMachine;

            if (MoneyInMachine > 0)
            {
                MoneyInMachine -= amountToRemove;

                result = $"Your change is ";
                result += $"{MoneyInMachine}";

                //To track money pool after transaction
                decimal after = MoneyInMachine;

                //Tracking current money
                track.Track(message, before, after);
            }
            else
            {
                result = "No money to return";
            }

            return result;
        }
    }
}
