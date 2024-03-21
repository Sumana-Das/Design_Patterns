using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public interface ICreditCardFactory
    {
        public ICreditCard CreateProduct();
    }
}
