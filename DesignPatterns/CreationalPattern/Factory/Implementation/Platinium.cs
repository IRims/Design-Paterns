using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Factory.Implementation
{
    public class Platinium : IPaymentCard
    {
        public int GetCardCharges()
        {
            return 2500;
        }

        public int GetCardLimit()
        {
            return 200000;
        }

        public string GetCardType()
        {
            return "Platinium Card";
        }

        public int Validity()
        {
            return 1095;
        }
    }
}
