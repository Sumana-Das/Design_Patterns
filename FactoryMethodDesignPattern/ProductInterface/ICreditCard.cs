using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public interface ICreditCard
    {
        void GetCardType();
        void AccountDetails();
        void GetCreditLimit();
    }
}
