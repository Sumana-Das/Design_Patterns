using System;
using FactoryMethodDesignPattern.ConcreteCreators;

namespace FactoryMethodDesignPattern
{
    class SmartClient
    {
        static void Main(string[] args)
        {
            ClientMethod(new MoneyBackCardFactory());
            ClientMethod(new PlatinumCardFactory());
        }
        public static void ClientMethod(ICreditCardFactory cardType)
        {
            ICreditCard cardDetails = cardType.CreateProduct();

            cardDetails.GetOffers();
            cardDetails.GetCreditLimit();
            cardDetails.GetAccountStatement();
        }
    }
}
