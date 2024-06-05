using System;
using DesignPatterns.CreationalPattern;
using DesignPatterns.CreationalPattern.Factory.Implementation;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            //Singleton singleton = Singleton.GetSingletonObject();
            //singleton.Print();
            //Singleton singleton1 = Singleton.GetSingletonObject();
            //singleton.Print();
            //Singleton singleton2 = Singleton.GetSingletonObject();
            //singleton.Print();
            #endregion

            #region Factory
            IPaymentCard card;
            Console.WriteLine("Please Enter Your Card Type");
            string type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "silver":
                    card = new Silver();
                    PrintCardDetails(card);
                    break;
                case "gold":
                    card = new Gold();
                    PrintCardDetails(card);
                    break;
                case "platinium":
                    card = new Platinium();
                    PrintCardDetails(card);
                    break;
                default:
                    card = null;
                    PrintCardDetails(card);
                    break;
            }
            #endregion
        }
        #region Factory Methods
        public static void PrintCardDetails(IPaymentCard Card)
        {
            if(Card!= null)
            {
                Console.WriteLine("Card type: "+Card.GetCardType());
                Console.WriteLine("Validity: " + Card.Validity());
                Console.WriteLine("Card Limit: "+Card.GetCardLimit());
                Console.WriteLine("Annual Charges: "+Card.GetCardCharges());
            }
            else
            {
                Console.WriteLine("INVALID CARD TYPE");
            }
        }
        #endregion
    }
}
