using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Drinks = child
    public class Drinks : ProductItem
    {
        int energy;
        public int Energy { get { return energy; } set { energy = value; } }

        decimal sugar;
        public decimal Sugar { get { return sugar; } set { sugar = value; } }

        decimal sodium;
        public decimal Sodium { get { return sodium; } set { sodium = value; } }

        public override string Info()
        {
            return base.Info() + $"\nCalories: {Energy}  \nSugar: {Sugar} %\nSodium: {Sodium} %";
        }

        public const string Message = "Drinking..glug..glug... Yummy! ";

        public Drinks(string productName, decimal price, int remainingitems):base(productName, price, remainingitems, Message)
        {
        }
        public Drinks(string productName, int energy, decimal sugar, decimal sodium) : base(productName)
        {
        }

        public List<ProductItem> DrinksInfo()
        {
            List<ProductItem> items = new List<ProductItem>();

            items.Add(new Drinks("Cold Coffee Latte Beverage", 120, 14.0M, 11.0M));
            items.Add(new Drinks("Iced Tea Beverage", 100, 25.0M, 30.0M));
            items.Add(new Drinks("Diet Sprite Beverage", 0, 0M, 1.0M));
            items.Add(new Drinks("Fanta Exotic Beverage", 175, 13.0M, 0M));
            items.Add(new Drinks("Coca Cola Beverage", 140, 39.0M, 1.0M));

            return items;
        }
    }
}
