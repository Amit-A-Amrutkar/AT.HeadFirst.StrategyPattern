using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FLY--> FlyWithWings");
        }
    }
}
