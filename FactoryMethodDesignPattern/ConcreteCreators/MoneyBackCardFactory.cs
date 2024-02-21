using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    public class MoneyBackCardFactory : CreditCardFactory
    {
        public override ICreditCard CreateProduct()
        {
            return new MoneyBackCard();
        }
    }
}
