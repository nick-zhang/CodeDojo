using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeDojoTest
{
    [TestClass]
    public class EnumeratorTest2
    {
        [TestMethod]
        public void Test()
        {
            var endlessList = new EndlessList();
            var enumerable = endlessList.GetOdds().MyTake(5);
            foreach (var e in enumerable)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class EndlessList : IEnumerable<int>
    {
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            int val = 0;
            while (true)
            {
                Console.Out.WriteLine("returning " + val);
                yield return val++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<int>)this).GetEnumerator();
        }
    }

    public static class Extensions
    {
        public static IEnumerable<int> MyTake(this IEnumerable<int> list, int count)
        {
            var index = 0;
            foreach (var item in list)
            {
                if (index++ < count)
                    yield return item;
                else
                    yield break;
            }
        }

        public static IEnumerable<int> GetOdds(this IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                if (item % 2 == 1)
                    yield return item;
            }
        }
    }
}
