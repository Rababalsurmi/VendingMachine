using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachine.Model
{
    public abstract class ProductItem 
    {
        public Dictionary<string, ProductItem> VendingMachineItems = new Dictionary<string, ProductItem>();

        protected string[] products;

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int RemainingItems { get; set; }

        public string VendedMessage { get; set; }

        public string SoldOutMessage { get; set; }

       

        public ProductItem()
        {
        }

        public ProductItem(string productName)
        {
            ProductName = productName;
        }

        public ProductItem(string productName, decimal price, int remainingitems, string vendedMessage)
        {
            ProductName = productName;
            Price = price;
            RemainingItems = remainingitems;
            VendedMessage = vendedMessage;
            SoldOutMessage = $"Sold out of {this.ProductName}!\nBuy something else!";
        }

        public virtual string Info()
        {
            return $"\n{ProductName}";
        }
        public virtual string[] Products()
        {
            return products;
        }
        public void AddInfo(string newProduct)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = newProduct;
        }

        public void Examine()
        {
            Console.WriteLine($"\n\n{"#".PadRight(5)} {"Stock"} { "Product".PadRight(30) } { "Price".PadLeft(7)}");

            foreach (KeyValuePair<string, ProductItem> kvp in VendingMachineItems)
            {
                if (kvp.Value.RemainingItems > 0)
                {
                    string itemNumber = kvp.Key.PadRight(5);
                    string itemsRemaining = kvp.Value.RemainingItems.ToString().PadRight(3);
                    string productName = kvp.Value.ProductName.PadRight(30);
                    string price = kvp.Value.Price.ToString("C").PadLeft(7);

                    //result = $"{itemNumber} {itemsRemaining} {productName} Costs: {price} each";
                    Console.WriteLine($"{itemNumber} {itemsRemaining} {productName} Costs: {price} each");
                }
                else
                {
                    //result = $"{kvp.Key}: {kvp.Value.ProductName} IS SOLD OUT.";
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.ProductName} IS SOLD OUT.");
                }
            }
        }

        public void Use(string choice)
        {
            Console.WriteLine();
            Console.WriteLine($"Enjoy your {VendingMachineItems[choice].ProductName}\n{VendingMachineItems[choice].VendedMessage}");
            Console.WriteLine();
        }

        public bool RemoveItem()
        {
            if (RemainingItems > 0)
            {
                RemainingItems--;
                return true;
            }
            return false;
        }

    }
}
