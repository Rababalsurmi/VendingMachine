using System;
using System.Collections.Generic;
using System.Text;

// ProductItem = Parent (Abstact class) and Drinks = child

namespace VendingMachine.Model
{
    public class Drinks : ProductItem
    {
        public const string Message = "Drinking... Yum! ";

        public Drinks(string productName, decimal price, int remainingitems):base(productName, price, remainingitems, Message)
        {
        }
    }
}
