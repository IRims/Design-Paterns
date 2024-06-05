using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Factory.Implementation
{
    public class Gold : IPaymentCard
    {
        public int GetCardCharges()
        {
            return 2000;
        }

        public int GetCardLimit()
        {
            return 100000;
        }

        public string GetCardType()
        {
            return "Gold Card";
        }

        public int Validity()
        {
            return 730;
        }
    }
}
