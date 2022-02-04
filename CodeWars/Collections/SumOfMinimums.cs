using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

//https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/train/csharp
namespace CodeWars.Collections
{
    class Kata
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(26, Kata.SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }));
            Assert.AreEqual(9, Kata.SumOfMinimums(new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } }));
            Assert.AreEqual(76, Kata.SumOfMinimums(new int[4, 4] { { 11, 12, 14, 54 }, { 67, 89, 90, 56 }, { 7, 9, 4, 3 }, { 9, 8, 6, 7 } }));
        }
    }
}
