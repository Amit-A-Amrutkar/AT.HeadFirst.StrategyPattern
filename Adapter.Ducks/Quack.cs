using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    public class Quack : IQuackBehavior
    {
         void IQuackBehavior.quack()
        {
            Console.WriteLine("Quack --> Quack");
        }
    }
}
