using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VendingMachine.Model
{
    public class MoneyTracker
    {
        public void Track(string message, decimal moneyBefore, decimal moneyAfter)
        {
            DateTime date = DateTime.Now;
            string dateString = date.ToString("MM/dd/yyyy hh:mm:ss tt");
            dateString = dateString.PadRight(30);

            message = message.PadRight(50);

            string moneyBeforeString = moneyBefore.ToString("C");
            moneyBeforeString = moneyBeforeString.PadLeft(10).PadRight(15);

            string moneyAfterString = moneyAfter.ToString("C").PadLeft(10);

            string trackLine = $"{dateString} {message} {moneyBeforeString} {moneyAfterString}";

            try
            {
                using (StreamWriter sw = new StreamWriter("TrackMoney.txt", true))
                {
                    sw.WriteLine(trackLine);
                }
            }
            catch
            {
                Console.WriteLine("Error when trying to track money");
                return;
            }
        }
    }
}
