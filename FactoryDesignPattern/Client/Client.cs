using System;

namespace FactoryDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the card type:");
            string cardType = Console.ReadLine();
            
            ClientMethod(cardType);
        }
        public static void ClientMethod(string cardType)
        {
            ICreditCard cardDetails = CreditCardFactory.GetCardType(cardType);

            cardDetails.GetOffers();
            cardDetails.GetCreditLimit();
            cardDetails.GetAccountStatement();
        }
    }
}
