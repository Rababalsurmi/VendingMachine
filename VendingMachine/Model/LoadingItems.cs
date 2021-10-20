using System;
using System.Collections.Generic;
using System.Text;



namespace VendingMachine.Model
{
    public class LoadingItems
    {
        public Dictionary<string, ProductItem> GetVendingItems()
        {
            Dictionary<string, ProductItem> items = new Dictionary<string, ProductItem>();

            items.Add("A1", new Drinks("Cold Coffee Latte", 3.05M, 5));
            items.Add("A2", new Drinks("Iced Tea", 1.50M, 5));
            items.Add("A3", new Drinks("Diet Sprite", 1.55M, 5));
            items.Add("A4", new Drinks("Fanta Exotic", 2.55M, 5));
            items.Add("A5", new Drinks("Coca Cola", 1.55M, 5));

            items.Add("B1", new Chocolate("Kit Kat", 1.50M, 5));
            items.Add("B2", new Chocolate("Snickers", 1.25M, 4));
            items.Add("B3", new Chocolate("Twix", 1.55M, 5));
            items.Add("B4", new Chocolate("Kinder Egg", 2.55M, 8));
            items.Add("B5", new Chocolate("Marabou", 3.55M, 9));

            items.Add("C1", new Nuts("Peanuts", 2.50M, 6));
            items.Add("C2", new Nuts("Cashews", 2.55M, 5));
            items.Add("C3", new Nuts("Almonds", 1.50M, 3));
            items.Add("C4", new Nuts("Walnuts", 1.25M, 10));
            items.Add("C5", new Nuts("Peacans", 2.55M, 5));

            items.Add("D1", new Crisps("OLW Salt & Vinegar", 2.50M, 6));
            items.Add("D2", new Crisps("OLW Sourcream & Onions", 2.55M, 5));
            items.Add("D3", new Crisps("OLW Grill", 1.50M, 3));
            items.Add("D4", new Crisps("Estrella Dill", 1.25M, 2));
            items.Add("D5", new Crisps("Estrella Ranch", 2.55M, 7));

            return items;
        }
    }
}
