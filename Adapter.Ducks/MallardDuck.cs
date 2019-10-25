using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
            
        }
        public override void display()
        {
            Console.WriteLine("MallardDuck -- > Display");
        }
    }
}
