using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Chocolate = child
    public class Chocolate : ProductItem
    {
        int cocoa;
        public int Cocoa { get { return cocoa; } set { cocoa = value; } }

        decimal sugar;
        public decimal Sugar { get { return sugar; } set { sugar = value; } }

        decimal weight;
        public decimal Weight { get { return weight; } set { weight = value; } }

        public override string Info()
        {
            return base.Info() + $"\nCocoa: {Cocoa} % \nSugar: {Sugar} g\nWeight: {Weight} g";
        }

        public const string Message = "Chocolate Munching...Chomp chomp... Yum! Yum! ";

        public Chocolate(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }

        public Chocolate(string productName, int cocoa, decimal sugar, decimal weight) : base(productName)
        {
        }
        public Chocolate(int cocoa, decimal sugar, decimal weight)
        {
        }

        public List<ProductItem> ChocolateInfo()
        {
            List<ProductItem> items = new List<ProductItem>();

            items.Add(new Chocolate("Kit Kat Chocolate bar", 45, 7.1M, 15.4M));
            items.Add(new Chocolate("Snickers Chocolate bar", 30, 30.0M, 57.0M));
            items.Add(new Chocolate("Twix Chocolate bar", 49, 27.0M, 50.7M));
            items.Add(new Chocolate("Kinder Egg Chocolate", 29, 53.3M, 100.0M));
            items.Add(new Chocolate("Marabou Chocolate bar", 45, 23.8M, 250.0M));

            return items;
        }

    }
}
