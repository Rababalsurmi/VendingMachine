using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Drinks = child
    public class Drinks : ProductItem
    {
        public const string Message = "Drinking..glug..glug... Yummy! ";

        public Drinks(string productName, decimal price, int remainingitems):base(productName, price, remainingitems, Message)
        {
        }
        public Drinks(string productName) : base(productName)
        {
        }
    }
}
