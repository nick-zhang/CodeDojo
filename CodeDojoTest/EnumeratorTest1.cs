using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnumeratorTest
{
    [TestClass]
    public class EnumeratorTest
    {
        public static IEnumerable<int> ThreeNumbersDebug()
        {
            Console.WriteLine("Returning 3");
            yield return 3;
            Console.WriteLine("Returning 11");
            yield return 11;
            Console.WriteLine("Returning 27");
            yield return 27;
        }

        [TestMethod]
        public void Test()
        {
            var list = ThreeNumbersDebug();
            foreach (var item in list)
            {
                Console.WriteLine("Got value {0}", item); 
            }
        }
    }
}
