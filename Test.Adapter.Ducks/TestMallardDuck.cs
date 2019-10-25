using Adapter.Ducks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Test.Adapter.Ducks
{
    public class TestMallardDuck
    {
        Duck mallardduck;

        public TestMallardDuck()
        {

            mallardduck = new MallardDuck();

        }

        [Fact]
        public void CheckType()
        {

            Assert.IsType<MallardDuck>(mallardduck);

        }

        [Fact]
        public void CanFly()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                mallardduck.performFly();

                string expected =
                    string.Format("FLY--> FlyWithWings{0}", Environment.NewLine);
                Assert.Equal(expected, sw.ToString());
            }

        }

        [Fact]
        public void CanQuack()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                mallardduck.perfomQuack();

                string expected =
                    string.Format("Quack --> Quack{0}", Environment.NewLine);
                Assert.Equal(expected, sw.ToString());
            }

        }
    }
}
