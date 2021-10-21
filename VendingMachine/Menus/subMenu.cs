using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Menus
{
    public class SubMenu
    {
        private MethodsVendingMachine VendingM;

        public SubMenu(MethodsVendingMachine VendingM)
        {
            this.VendingM = VendingM;
        }

        public void Display()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1] >> Insert Money");
                Console.WriteLine("2] >> Select Product");
                Console.WriteLine("3] >> End Transaction");
                Console.WriteLine("Q] >> Return to Main Menu");
                Console.WriteLine();
                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                Console.WriteLine();
                Console.Write("Select an Option: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine(">>> How much do you want to insert?");
                    Console.WriteLine();
                    Console.WriteLine("Choose one of the fixed denominations");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.WriteLine("1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr or 1000kr");
                        string amountToInsert = Console.ReadLine();

                        if (amountToInsert == "1kr"
                            || amountToInsert == "5kr"
                            || amountToInsert == "10kr"
                            || amountToInsert == "20kr"
                            || amountToInsert == "50kr"
                            || amountToInsert == "100kr"
                            || amountToInsert == "500kr"
                            || amountToInsert == "1000kr")
                        {
                            VendingM.InsertMoney(amountToInsert);
                            Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                            //if (!VendingM.InsertMoney(amountToInsert))
                            //{
                                
                            //    //Console.WriteLine("Insert a valid amount.");
                            //}
                            //else
                            //{
                            //    //Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                            //    Console.WriteLine("Insert a valid amount.");
                            //    break;
                            //}
                        }
                    }
                }
                else if (input == "2")
                {
                    while (true)
                    {
                        VendingM.ShowAll();
                        Console.Write(">>> What item do you want? ");
                        string choice = Console.ReadLine();

                        if (this.VendingM.ItemExists(choice) && VendingM.Purchase(choice))
                        {
                            Console.WriteLine($"Enjoy your {VendingM.VendingMachineItems[choice].ProductName}\n{VendingM.VendingMachineItems[choice].VendedMessage}");
                            break;
                        }
                        else if (!VendingM.ItemExists(choice))
                        {
                            Console.Clear();
                            Console.WriteLine("**INVALID ITEM**");
                        }
                        else if (VendingM.ItemExists(choice) && VendingM.MoneyInMachine > VendingM.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine(VendingM.VendingMachineItems[choice].SoldOutMessage);
                        }
                        else if (VendingM.MoneyInMachine < VendingM.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine(VendingM.NotEnoughMoneyError);
                            break;
                        }
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("End Transaction");
                    Console.WriteLine(VendingM.EndTransaction());
                }
                else if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();

            }
        }
    }
}
