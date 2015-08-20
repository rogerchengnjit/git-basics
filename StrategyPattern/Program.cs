using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            
                RedHeadDuck redHead = new RedHeadDuck();
                redHead.display();
                redHead.setFlyBehavior(new FlyWithRockets());// Learned from experience. This line takes care of error "Additional information: Object reference not set to an instance of an object." for performFly().
                redHead.performFly();
                Console.ReadLine();
            //}

            /*catch (NullReferenceException nre)
            {
                Console.WriteLine(
                 "\nCan't call BarMethod(), foo is null.\n" +
                 nre.Message);
            }*/
            
        }
    }
}
