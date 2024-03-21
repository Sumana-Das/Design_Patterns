using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class PlatinumCard : ICreditCard
    {
        public void GetOffers()
        {
            Console.WriteLine("Platinum Card");
        }
        public void GetAccountStatement()
        {
            Console.WriteLine("Platinum Account Details");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("Platinum Credit Limit");
        }
    }
}
