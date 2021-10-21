using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;


namespace VendingMachine.Menus
{
    public class MainMenu
    {
        public void Display()
        {
            MethodsVendingMachine VendingM = new MethodsVendingMachine();

            Console.WriteLine("WELCOME TO MY VENDING MACHINE !!!!");

            bool run = true;
            while(run)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1] Display Vending Machine Products");
                Console.WriteLine("2] Purchase");
                Console.WriteLine("Q] Quit");

                Console.Write("Select an Option: ");
                string input = Console.ReadLine();

                if( input == "1")
                {
                    Console.WriteLine("Displaying Items");
                    VendingM.ShowAll();
                }
                else if (input == "2")
                {
                    SubMenu subMenu = new SubMenu(VendingM);
                    subMenu.Display();
                }
                else if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }   
    }
}
