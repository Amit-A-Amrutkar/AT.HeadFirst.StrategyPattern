using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack --> MuteQuack");
        }
    }
}
