using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Factory.Implementation
{
    public class Silver : IPaymentCard
    {
        public int GetCardCharges()
        {
            return 1500;
        }

        public int GetCardLimit()
        {
            return 50000;
        }

        public string GetCardType()
        {
            return "Silver Card";
        }

        public int Validity()
        {
            return 365;
        }
    }
}
