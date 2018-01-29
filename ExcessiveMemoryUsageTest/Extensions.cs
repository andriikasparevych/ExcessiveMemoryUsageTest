using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcessiveMemoryUsageTest
{
    public static class Extensions
    {
        private static Random _random = new Random(DateTime.Now.Millisecond);
        public static T GetRandom<T>(this IList<T> collection)
        {
            return collection[_random.Next(0, collection.Count() - 1)];
        }
    }
}
