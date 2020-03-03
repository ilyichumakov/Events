using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class ConcreteObserver
    {
        public static void ConcreteObserverWithParams1(bool paramenter)
        {
            Console.WriteLine("ConcreteObserverWithParams1");
        }
        public static void ConcreteObserverWithParams2(bool paramenter)
        {
            Console.WriteLine("ConcreteObserverWithParams2");
        }
    }
}
