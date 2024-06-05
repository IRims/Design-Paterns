using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern
{
    class Singleton
    {
        public static Singleton singletonobject;
        public static int ObjectCount = 0;

        private Singleton()
        {

        }
        public static Singleton GetSingletonObject()
        {
            if(singletonobject == null)
            {
                singletonobject = new Singleton();
                ObjectCount++;
            }
            return singletonobject;
        }
        public void Print()
        {
            Console.WriteLine("Object Created "+ ObjectCount +" Times");
        }
    }
}
