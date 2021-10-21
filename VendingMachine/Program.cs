using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using VendingMachine.Model;
using VendingMachine.Menus;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MainMenu menu = new MainMenu();
            menu.Display();
        }
    }
}
