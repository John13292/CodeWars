using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeWars.Collections
{
    internal class RESOLVED_FindTheDuplicatedNumberInAConsecutiveUnsortedList
    {
        public static int FindDup(int[] arr)
        {
            //Array.Sort(arr);

            //int duplicateValue = 0;

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] == arr[i + 1])
            //    {
            //        duplicateValue = arr[i];
            //    }
            //}

            //return duplicateValue;

            return arr.GroupBy(x => x).First(x => x.Count() == 2).Key;
        }

        [TestFixture]
        public class Sample_Test
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(new[] { new int[] { 1, 1, 2, 3 } }).Returns(1);
                    yield return new TestCaseData(new[] { new int[] { 5, 4, 3, 2, 1, 1 } }).Returns(1);
                    yield return new TestCaseData(new[] { new int[] { 1, 3, 2, 5, 4, 5, 7, 6 } }).Returns(5);
                    yield return new TestCaseData(new[] { new int[] { 8, 2, 6, 3, 7, 2, 5, 1, 4 } }).Returns(2);
                }
            }

            [Test, TestCaseSource("testCases")]
            public int Test(int[] arr) => RESOLVED_FindTheDuplicatedNumberInAConsecutiveUnsortedList.FindDup(arr);
        }
    }
}
