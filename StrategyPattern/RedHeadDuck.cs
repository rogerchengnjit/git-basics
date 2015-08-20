using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RedHeadDuck : Duck
    {
      FlyBehavior  flyBehavior = new FlyWithWings();

      public void display ()
      {
        Console.WriteLine ("I am a real red head duck.");
      }
    }
}
