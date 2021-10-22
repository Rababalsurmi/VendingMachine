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

            items.Add("A1", new Drinks("Cold Coffee Latte Beverage", 3.05M, 5));
            items.Add("A2", new Drinks("Iced Tea Beverage", 1.50M, 5));
            items.Add("A3", new Drinks("Diet Sprite Beverage", 1.55M, 5));
            items.Add("A4", new Drinks("Fanta Exotic Beverage", 2.55M, 5));
            items.Add("A5", new Drinks("Coca Cola Beverage", 1.55M, 5));

            items.Add("B1", new Chocolate("Kit Kat Chocolate bar", 1.50M, 5));
            items.Add("B2", new Chocolate("Snickers Chocolate bar", 1.25M, 4));
            items.Add("B3", new Chocolate("Twix Chocolate bar", 1.55M, 5));
            items.Add("B4", new Chocolate("Kinder Egg Chocolate", 2.55M, 8));
            items.Add("B5", new Chocolate("Marabou Chocolate bar", 3.55M, 9));

            items.Add("C1", new Nuts("Peanuts Nuts", 2.50M, 6));
            items.Add("C2", new Nuts("Cashews Nuts", 2.55M, 5));
            items.Add("C3", new Nuts("Almonds Nuts", 1.50M, 3));
            items.Add("C4", new Nuts("Walnuts Nuts", 1.25M, 10));
            items.Add("C5", new Nuts("Peacans Nuts", 2.55M, 5));

            items.Add("D1", new Crisps("OLW Salt & Vinegar Chips", 2.50M, 6));
            items.Add("D2", new Crisps("OLW Sourcream & Onions Chips", 2.55M, 5));
            items.Add("D3", new Crisps("OLW Grill Chips", 1.50M, 3));
            items.Add("D4", new Crisps("Estrella Dill Chips", 1.25M, 2));
            items.Add("D5", new Crisps("Estrella Ranch Chips", 2.55M, 7));

            return items;
        }

        public List< ProductItem> ShowVendingItems()
        {
            List<ProductItem> items = new List<ProductItem>();

            items.Add(new Drinks("Cold Coffee Latte Beverage"));
            items.Add(new Drinks("Iced Tea Beverage"));
            items.Add(new Drinks("Diet Sprite Beverage"));
            items.Add( new Drinks("Fanta Exotic Beverage"));
            items.Add( new Drinks("Coca Cola Beverage"));

            items.Add(new Chocolate("Kit Kat Chocolate bar"));
            items.Add(new Chocolate("Snickers Chocolate bar"));
            items.Add(new Chocolate("Twix Chocolate bar"));
            items.Add(new Chocolate("Kinder Egg Chocolate"));
            items.Add(new Chocolate("Marabou Chocolate bar"));

            items.Add(new Nuts("Peanuts Nuts"));
            items.Add(new Nuts("Cashews Nuts"));
            items.Add(new Nuts("Almonds Nuts"));
            items.Add(new Nuts("Walnuts Nuts"));
            items.Add(new Nuts("Peacans Nuts"));

            items.Add(new Crisps("OLW Salt & Vinegar Chips"));
            items.Add(new Crisps("OLW Sourcream & Onions Chips"));
            items.Add(new Crisps("OLW Grill Chips"));
            items.Add(new Crisps("Estrella Dill Chips"));
            items.Add(new Crisps("Estrella Ranch Chips"));

            return items;
        }
    }
}
