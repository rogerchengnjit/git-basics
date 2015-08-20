using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyWithWings : FlyBehavior //this class implements interface FlyBehavior in the method Fly()
    {
        
        public FlyWithWings()//CONSTRUCTOR
        {
            //Console.WriteLine("I am flying with wings");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying with wings");
        }
    }
}
