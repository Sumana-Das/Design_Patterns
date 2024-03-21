using System;

namespace FactoryMethodDesignPattern
{
    public class MoneyBackCard : ICreditCard
    {
        public void GetOffers()
        {
            Console.WriteLine("MoneyBackCard Card");
        }
        public void GetAccountStatement()
        {
            Console.WriteLine("MoneyBackCard Account Details");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("MoneyBackCard Credit Limit");
        }
    }
}
