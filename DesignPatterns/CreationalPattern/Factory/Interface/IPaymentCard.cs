using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern
{
    public interface IPaymentCard
    {
        string GetCardType();
        int GetCardLimit();
        int GetCardCharges();
        int Validity();
    }
}
