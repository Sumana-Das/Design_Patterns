using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface ICreditCard
    {
        void GetOffers();
        void GetAccountStatement();
        void GetCreditLimit();
    }
}
