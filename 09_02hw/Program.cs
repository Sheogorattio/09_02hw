using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClass;


namespace _09_02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SourceEventInt addMoney = new SourceEventInt();
                SourceEventInt spendMoney = new SourceEventInt();
                SourceEventInt editPin = new SourceEventInt();
                Card card = new Card("Name", 9123, new DateTime(2025, 2, 12), 3000);

                addMoney.ev += card.ReplenishAccount;
                spendMoney.ev += card.SpendMoney;
                editPin.ev += card.EditPin;

                addMoney.ev.Invoke(2000);
                spendMoney.ev.Invoke(5000);

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }
            
        }

    }
}
