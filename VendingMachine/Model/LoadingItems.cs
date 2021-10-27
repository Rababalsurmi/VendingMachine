using System;
using System.Collections.Generic;
using System.Text;



namespace VendingMachine.Model
{
    public class LoadingItems
    {
        //public ProductItem[] GetVendingItems()
        //{
        //    Chocolate kitKat = new Chocolate("Kit Kat Chocolate bar", 1.50M, 5);
        //    Chocolate snickers = new Chocolate("Snickers Chocolate bar", 1.25M, 4);
        //    Chocolate twix = new Chocolate("Twix Chocolate bar", 1.55M, 5);
        //    Chocolate kinder = new Chocolate("Kinder Egg Chocolate", 2.55M, 8);
        //    Chocolate marabou = new Chocolate("Marabou Chocolate bar", 3.55M, 9);

        //    Drinks coffee = new Drinks("Cold Coffee Latte Beverage", 3.05M, 5);
        //    Drinks tea = new Drinks("Iced Tea Beverage", 1.50M, 5);
        //    Drinks sprite = new Drinks("Diet Sprite Beverage", 1.55M, 5);
        //    Drinks fanta = new Drinks("Fanta Exotic Beverage", 2.55M, 5);
        //    Drinks cola = new Drinks("Coca Cola Beverage", 1.55M, 5);

        //    Nuts peanuts = new Nuts("Peanuts Nuts", 2.50M, 6);
        //    Nuts cashews = new Nuts("Cashews Nuts", 2.55M, 5);
        //    Nuts almonds = new Nuts("Almonds Nuts", 1.50M, 3);
        //    Nuts walnuts = new Nuts("Walnuts Nuts", 1.25M, 10);
        //    Nuts peacans = new Nuts("Peacans Nuts", 2.55M, 5);

        //    Crisps saltAndVinegar = new Crisps("OLW Salt & Vinegar Chips", 2.50M, 6);
        //    Crisps sourcream = new Crisps("OLW Sourcream & Onions Chips", 2.55M, 5);
        //    Crisps grill = new Crisps("OLW Grill Chips", 1.50M, 3);
        //    Crisps dill = new Crisps("Estrella Dill Chips", 1.25M, 2);
        //    Crisps ranch = new Crisps("Estrella Ranch Chips", 2.55M, 7);

        //    ProductItem[] items = new ProductItem[] { kitKat, snickers, twix, kinder, marabou, coffee, tea, sprite, fanta, cola, peanuts, cashews, almonds, walnuts, peacans, saltAndVinegar, sourcream, grill, dill, ranch};

        //    return items;
        //}

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

            items.Add(new Drinks("Cold Coffee Latte Beverage", 120, 14.0M, 11.0M));
            items.Add(new Drinks("Iced Tea Beverage", 100, 25.0M, 30.0M));
            items.Add(new Drinks("Diet Sprite Beverage", 0, 0M, 1.0M));
            items.Add( new Drinks("Fanta Exotic Beverage", 175, 13.0M, 0M));
            items.Add( new Drinks("Coca Cola Beverage", 140, 39.0M, 1.0M));

            items.Add(new Chocolate("Kit Kat Chocolate bar", 45, 7.1M, 15.4M));
            items.Add(new Chocolate("Snickers Chocolate bar", 30, 30.0M, 57.0M));
            items.Add(new Chocolate("Twix Chocolate bar", 49, 27.0M, 50.7M));
            items.Add(new Chocolate("Kinder Egg Chocolate", 29, 53.3M, 100.0M));
            items.Add(new Chocolate("Marabou Chocolate bar", 45, 23.8M, 250.0M));

            items.Add(new Nuts("Peanuts Nuts", 170, 7.1M, 0M));
            items.Add(new Nuts("Cashews Nuts", 160, 3.0M, 0M));
            items.Add(new Nuts("Almonds Nuts", 170, 7.1M, 0M));
            items.Add(new Nuts("Walnuts Nuts", 185, 4M, 0M));
            items.Add(new Nuts("Peacans Nuts", 181, 2.6M, 0M));

            items.Add(new Crisps("OLW Salt & Vinegar Chips", 7.7M, 12.1M, 0M));
            items.Add(new Crisps("OLW Sourcream & Onions Chips", 9.7M, 11.1M, 0M));
            items.Add(new Crisps("OLW Grill Chips", 5.7M, 10.1M, 0M));
            items.Add(new Crisps("Estrella Dill Chips", 33.8M, 1.7M, 0.8M));
            items.Add(new Crisps("Estrella Ranch Chips", 33.8M, 1.7M, 2.9M));

            return items;
        }
    }
}
