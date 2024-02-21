using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard CreateProduct();
    }
}
