using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.ConcreteCreators
{
    public class PlatinumCardFactory : ICreditCardFactory
    {
        public ICreditCard CreateProduct()
        {
            return new PlatinumCard();
        }
    }
}
