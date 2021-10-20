using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachine.Model
{
    public class VendingMachine
    {
        private MoneyTracker track = new MoneyTracker();

        public Dictionary<string, ProductItem> VendingMachineItems = new Dictionary<string, ProductItem>();

        LoadingItems LoadItems = new LoadingItems();

        public Money Money { get; }

        public string NotEnoughMoneyError = "Not enough money in the machine to complete the transaction.";

        public string MessageToUser;

        public VendingMachine()
        {
            this.VendingMachineItems = this.LoadItems.GetVendingItems();
            this.Money = new Money(this.track);
        }
    }
}
