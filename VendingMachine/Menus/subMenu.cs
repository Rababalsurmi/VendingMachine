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
                Console.WriteLine();
                Console.WriteLine("1] >> Insert Money");
                Console.WriteLine("2] >> Purchase Product");
                Console.WriteLine("3] >> End Transaction");
                Console.WriteLine("Q] >> Return to Main Menu");
                Console.WriteLine();
                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                Console.WriteLine();
                Console.Write("Select an Option then Press Enter: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine(">>> How much do you want to insert?");
                    Console.WriteLine();
                    Console.WriteLine("Choose one of the fixed denominations");
                    Console.WriteLine();

                    bool running = true;
                    while (running)
                    {
                        Console.WriteLine("1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr or 1000kr");
                        string amountToInsert = Console.ReadLine();

                        switch (amountToInsert)
                        {
                            case "1":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "5":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "10":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "20":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "50":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "100":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "500":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            case "1000":
                                VendingM.InsertMoney(amountToInsert);
                                Console.WriteLine($"Money in Machine: {VendingM.MoneyInMachine.ToString("C")}");
                                break;
                            default:

                                Console.WriteLine();
                                Console.WriteLine("** Invalid denominations **");
                                Console.WriteLine();
                                Console.WriteLine("** Try Again **");
                                break;

                        }
                        running = false;

                    }
                }
                else if (input == "2")
                {
                    while (true)
                    {
                        VendingM.Examine();
                        Console.WriteLine();
                        Console.Write(">>> Choose Product Number in Upper Case:  ");
                        string choice = Console.ReadLine();

                        if (VendingM.ItemExists(choice) && VendingM.Purchase(choice))
                        {
                            VendingM.Use(choice);
                           
                            break;
                        }
                        else if (!VendingM.ItemExists(choice))
                        {
                            Console.Clear();
                            Console.WriteLine("**INVALID ITEM**");
                        }
                        else if (VendingM.ItemExists(choice) && VendingM.MoneyInMachine > VendingM.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine();
                            Console.WriteLine(VendingM.VendingMachineItems[choice].SoldOutMessage);
                        }
                        else if (VendingM.MoneyInMachine < VendingM.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine();
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
