using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Nuts = child
    public class Nuts : ProductItem
    {
        public const string Message = "Nuts Munching... Yum! ";

        public Nuts(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }

        public Nuts(string productName) : base(productName)
        {
        }
    }
}
