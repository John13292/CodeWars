using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeWars
{
    public class MinMax
    {
        public static int[] minMax(int[] list)
        {
            var min = list.OrderBy(x => x).First();
            var max = list.OrderByDescending(x => x).First();

            return new int[] { min, max };
        }
    }


[TestFixture]
    public class MinMaxTests
    {

        [Test]
        public static void BasicTest()
        {
            Assert.AreEqual(new int[] { -1, 20 }, MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            Assert.AreEqual(new int[] { 1, 5 }, MinMax.minMax(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -3, 5 }, MinMax.minMax(new int[] { 1, 2, -3, 4, 5 }));
        }
    }
}
