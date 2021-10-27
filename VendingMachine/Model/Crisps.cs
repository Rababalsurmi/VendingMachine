using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Crisps = child
    public class Crisps : ProductItem
    {
        decimal fat;
        public decimal Fat { get { return fat; } set { fat = value; } }

        decimal sodium;
        public decimal Sodium { get { return sodium; } set { sodium = value; } }

        decimal cholestrol;
        public decimal Cholestrol { get { return cholestrol; } set { cholestrol = value; } }

        public override string Info()
        {
            return base.Info() + $"\nTotal Fat: {Fat} % \nSodium: {Sodium} %\nTotal Cholestrol: {Cholestrol} %";
        }
        public const string Message = "Munching Crisps ...Chomp chomp.... Mmmmmm! ";

        public Crisps(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }

        public Crisps(string productName, decimal fat, decimal sodium, decimal cholestrol) : base(productName)
        {
        }

        public List<ProductItem> CrispsInfo()
        {
            List<ProductItem> items = new List<ProductItem>();

            items.Add(new Crisps("OLW Salt & Vinegar Chips", 7.7M, 12.1M, 0M));
            items.Add(new Crisps("OLW Sourcream & Onions Chips", 9.7M, 11.1M, 0M));
            items.Add(new Crisps("OLW Grill Chips", 5.7M, 10.1M, 0M));
            items.Add(new Crisps("Estrella Dill Chips", 33.8M, 1.7M, 0.8M));
            items.Add(new Crisps("Estrella Ranch Chips", 33.8M, 1.7M, 2.9M));

            return items;
        }
    }
}
