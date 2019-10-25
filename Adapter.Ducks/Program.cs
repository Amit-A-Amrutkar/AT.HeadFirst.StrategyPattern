using System;

namespace Adapter.Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardduck = new MallardDuck();
            mallardduck.display();
            mallardduck.perfomQuack();
            mallardduck.performFly();


            Console.ReadLine();
        }
    }
}
