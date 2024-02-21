using System;
using FactoryMethodDesignPattern.ConcreteCreators;

namespace FactoryMethodDesignPattern
{
    class SmartClient
    {
        static void Main(string[] args)
        {
            ClientCode(new MoneyBackCardFactory());
            ClientCode(new PlatinumCardFactory());
        }
        public static void ClientCode(CreditCardFactory creator)
        {
            ICreditCard cardDetails = creator.CreateProduct();

            cardDetails.GetCardType();
            cardDetails.GetCreditLimit();
            cardDetails.AccountDetails();
        }
    }
}
