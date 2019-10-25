using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack --> Squeak");
        }
    }
}
