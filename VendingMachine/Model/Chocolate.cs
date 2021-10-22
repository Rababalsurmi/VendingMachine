using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Chocolate = child
    public class Chocolate : ProductItem
    {
        public const string Message = "Chocolate Munching...Chomp chomp... Yum! Yum! ";

        public Chocolate(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }

        public Chocolate(string productName) : base(productName)
        {
        }
    }
}
