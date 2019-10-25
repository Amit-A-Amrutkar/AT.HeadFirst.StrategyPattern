using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FLY--> FlyNoWay");
        }
    }
}
