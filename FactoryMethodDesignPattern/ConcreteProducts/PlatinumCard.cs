using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class PlatinumCard : ICreditCard
    {
        public void GetCardType()
        {
            Console.WriteLine("Platinum Card");
        }
        public void AccountDetails()
        {
            Console.WriteLine("Platinum Account Details");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("Platinum Credit Limit");
        }
    }
}
