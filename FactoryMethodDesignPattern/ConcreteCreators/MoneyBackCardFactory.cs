using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    public class MoneyBackCardFactory : ICreditCardFactory
    {
        public ICreditCard CreateProduct()
        {
            return new MoneyBackCard();
        }
    }
}
