using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Nuts = child
    public class Nuts : ProductItem
    {
        int energy;
        public int Energy { get { return energy; } set { energy = value; } }

        decimal protein;
        public decimal Protein { get { return protein; } set { protein = value; } }

        decimal cholestrol;
        public decimal Cholestrol { get { return cholestrol; } set { cholestrol = value; } }

        public override string Info()
        {
            return base.Info() + $"\nCalories from fat: {Energy}  \nProtein: {Protein} g\nCholestrol: {Cholestrol} %";
        }

        public const string Message = "Nuts Munching... Yum! ";

        public Nuts(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }

        public Nuts(string productName, int energy, decimal protein, decimal cholestrol) : base(productName)
        {
        }

        public List<ProductItem> NutsInfo()
        {
            List<ProductItem> items = new List<ProductItem>();

            items.Add(new Nuts("Peanuts Nuts", 170, 7.1M, 0M));
            items.Add(new Nuts("Cashews Nuts", 160, 3.0M, 0M));
            items.Add(new Nuts("Almonds Nuts", 170, 7.1M, 0M));
            items.Add(new Nuts("Walnuts Nuts", 185, 4M, 0M));
            items.Add(new Nuts("Peacans Nuts", 181, 2.6M, 0M));

            return items;
        }
    }
}
