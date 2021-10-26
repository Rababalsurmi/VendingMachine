using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    // ProductItem = Parent (Abstact class) and Chocolate = child
    public class Chocolate : ProductItem
    {
        int cacao;
        public int Cacao { get { return cacao; } set { cacao = value; } }

        int sugar;
        public int Sugar { get { return sugar; } set { sugar = value; } }

        int weight;
        public int Weight { get { return weight; } set { weight = value; } }

        public new string Info()
        {
            return base.Info() + $"\nCacao: {Cacao} % \nSugar: {Sugar}\nWeight: {Weight}";
        }

        public const string Message = "Chocolate Munching...Chomp chomp... Yum! Yum! ";

        public Chocolate(string productName, decimal price, int remainingitems) : base(productName, price, remainingitems, Message)
        {
        }

        public Chocolate(string productName) : base(productName)
        {
        }

    }
}
