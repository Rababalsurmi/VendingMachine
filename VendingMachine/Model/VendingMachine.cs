using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachine.Model
{
    public class MethodsVendingMachine : IVending
    {
        private MoneyTracker track = new MoneyTracker();

        public Dictionary<string, ProductItem> VendingMachineItems = new Dictionary<string, ProductItem>();

        LoadingItems LoadItems = new LoadingItems();

        public Money Money { get; }

        public decimal MoneyInMachine { get; private set; }

        public string NotEnoughMoneyError = "Not enough money in the machine to complete the transaction.";

        public string MessageToUser;


        public MethodsVendingMachine()
        {
            VendingMachineItems = LoadItems.GetVendingItems();
            Money = new Money(track);
        }

        public MethodsVendingMachine(MoneyTracker track)
        {
            MoneyInMachine = 0M;
            this.track = track;
        }

        public void ShowAll()
        {
            List<ProductItem> showItems = new List<ProductItem>();

            showItems = LoadItems.ShowVendingItems();
            
            Console.WriteLine($"\n{ "Product Nutrition Facts:".PadLeft(15) }");
            Console.WriteLine("----------------------------");
            
            foreach (ProductItem item in showItems)
            {
                string productInfo = item.Info();

                Console.WriteLine($"\n{productInfo}");
            }
        }

        public bool InsertMoney(string amount)
        {

            if (!decimal.TryParse(amount, out decimal amountInserted))
            {
                //amountInserted = 0M;
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

        //For testing purposes
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

        public bool ItemExists(string itemNumber)
        {
            return VendingMachineItems.ContainsKey(itemNumber);
        }


        public bool Purchase(string itemNumber)
        {
            
            if (ItemExists(itemNumber)
                && MoneyInMachine >= VendingMachineItems[itemNumber].Price // if we have more money in the machine than the price
                && VendingMachineItems[itemNumber].RemainingItems > 0
                && VendingMachineItems[itemNumber].RemoveItem())
            {
                // To display drink name and item number
                string message = $"{VendingMachineItems[itemNumber].ProductName} {itemNumber}"; 

                // Tracking before: current money in machine
                decimal before = MoneyInMachine;

                // Remove the money
                MoneyInMachine -= VendingMachineItems[itemNumber].Price;

                // Tracking after: current money in machine
                decimal after = MoneyInMachine;

                // Sales report
                track.Track(message, before, after);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
