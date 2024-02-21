using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCardType(string cardType)
        {
            ICreditCard creditCard = null;
            if(cardType == "MoneyBack")
            {
                creditCard = new MoneyBackCard();
            }
            else if(cardType == "Platinum")
            {
                creditCard = new PlatinumCard();
            }
            return creditCard;
        }
    }
}
