using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CodeWars.REFACTORING
{
    public class CubeIII
    {
        private int side;
        public int Side
        {
            get { return side; }
            set { side = Math.Abs(value); }
        }

        public int Volume => Side * Side * Side;

        public int Surface => Side * Side * 6;

        public CubeIII(int s)
        {
            Side = s;
        }

        public CubeIII() { }

    }


    [TestFixture]
    public class Tests
    {
        [Test]
        public static void TestGetAccessor()
        {
            CubeIII c = new CubeIII();
            Assert.AreEqual(0, c.Side, "The get-accessor should return 0");
        }

        [Test]
        public static void TestSetAccessor()
        {
            CubeIII c = new CubeIII();
            c.Side = 5;
            Assert.AreEqual(5, c.Side, "The set-accessor should have changed Side to 5");
        }
    }
}
