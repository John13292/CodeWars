using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CodeWars.REFACTORING
{
    public class CubeI
    {
        private int Side;

        public int GetSide ()
        {
            return this.Side;
        }

        public void SetSide(int value) 
        {
            if (value < 0)
            {
                this.Side = -1 * value;
            }
            this.Side = value;
        }

        public CubeI()
        {
            this.Side = 0;
        }
        public CubeI(int value)
        {

        }

    }


    [TestFixture]
    public class Test
    {
        [Test]
        public static void FixedTest()
        {
            CubeI c = new CubeI();
            Assert.AreEqual(0, c.GetSide(), "when not set before, Side should be 0");
            c.SetSide(5);
            Assert.AreEqual(5, c.GetSide(), "Should return 5");
        }
    }
}
