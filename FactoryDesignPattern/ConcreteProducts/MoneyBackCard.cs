using System;

namespace FactoryDesignPattern
{
    public class MoneyBackCard : ICreditCard
    {
        public void GetCardType()
        {
            Console.WriteLine("MoneyBackCard Card");
        }
        public void AccountDetails()
        {
            Console.WriteLine("MoneyBackCard Account Details");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("MoneyBackCard Credit Limit");
        }
    }
}
