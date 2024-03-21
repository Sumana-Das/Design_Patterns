using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public interface ICreditCard
    {
        void GetOffers();
        void GetAccountStatement();
        void GetCreditLimit();
    }
}
