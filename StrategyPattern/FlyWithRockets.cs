using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyWithRockets:FlyBehavior
    {
        public FlyWithRockets() //CONSTRUCTOR
        {
        }

        public void Fly()
        {
            Console.WriteLine("I am flying with rockets!");
        }

    }
}
