using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Ducks
{
    public abstract class Duck
    {
       public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {


        }

        public abstract void display();

        public void swim ()
        {
            Console.WriteLine("All ducks float,even decoy");
        }

        public void performFly()
        {

            flyBehavior.fly();

        }

        public void perfomQuack()
        {

            quackBehavior.quack();
        }
    }
}
