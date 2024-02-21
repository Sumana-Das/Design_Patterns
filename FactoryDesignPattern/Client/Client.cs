using System;

namespace FactoryDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the card type:");
            string cardType = Console.ReadLine();
            
            ClientCode(cardType);
        }
        public static void ClientCode(string cardType)
        {
            ICreditCard cardDetails = CreditCardFactory.GetCardType(cardType);

            cardDetails.GetCardType();
            cardDetails.GetCreditLimit();
            cardDetails.AccountDetails();
        }
    }
}
