using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    public class PlatinumCardFactory : CreditCardFactory
    {
        public override ICreditCard CreateProduct()
        {
            return new PlatinumCard();
        }
    }
}
