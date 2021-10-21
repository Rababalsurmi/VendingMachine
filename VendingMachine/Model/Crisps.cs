using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Crisps = child
    public class Crisps : ProductItem
    {
        public const string Message = "Munching Crisps ...Chomp chomp.... Mmmmmm! ";

        public Crisps(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }
    }
}
