using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachine.Model
{
    public abstract class ProductItem 
    {
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

        public bool RemoveItem()
        {
            if (RemainingItems >0)
            {
                RemainingItems--;
                return true;
            }
            return false;
        }
        public string Info()
        {
            return $"\n{ProductName}";
        }
        
    }
}
