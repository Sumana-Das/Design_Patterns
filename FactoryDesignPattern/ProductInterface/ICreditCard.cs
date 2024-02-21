using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface ICreditCard
    {
        void GetCardType();
        void AccountDetails();
        void GetCreditLimit();
    }
}
