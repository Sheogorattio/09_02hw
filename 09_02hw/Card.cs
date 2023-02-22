using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Card
    {
        public Card(string name, int pin, DateTime expirationDate,int currentMoneyValue)
        {
            Name = name;
            Pin = pin;
            ExpirationDate = expirationDate;
            CurrentMoneyValue = currentMoneyValue;
            CurrentCreditLimit = 20000;
        }
        public string Name { get; set; }
        int Pin { get; set; }
        public DateTime ExpirationDate { get; set; }
        int CurrentCreditLimit{get;set;}
        int CurrentMoneyValue { get; set; }
        public void ReplenishAccount(int value)
        {
            CurrentMoneyValue+=value;
        }
        public void SpendMoney(int value)
        {
            if (CurrentMoneyValue >= value) CurrentMoneyValue -= value;
            else throw new ArgumentException("CurrentMoneyValue <= value");
        }
        public void SpendCreditMoney(int value)
        {
            if(CurrentCreditLimit >= value) CurrentCreditLimit -= value;
            else throw new ArgumentException("CurrentCreditLimit <= value");
        }
        public void EditPin(int value)
        {
            Pin = value;
        }
    }

    public delegate void CardDelegateVoid(int value);

    public class SourceEventInt
    {
       public CardDelegateVoid ev;
       public void GenerateEvent(int value)
        {
            ev.Invoke(value);
        }
    }

}
