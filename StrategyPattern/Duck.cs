using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        FlyBehavior flyBehavior = null;

        public void setFlyBehavior (FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void performFly()
        {
            flyBehavior.Fly();
        }

    }
}
