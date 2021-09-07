using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FindDivisorsLibrary;


namespace UnitTestFindDivisors
{
    [TestClass]
    public class DivisorsTest
    {
        /// <summary>
        /// When n1 is less than n2 and n1, n2 > 0
        /// </summary>
        [TestMethod]
        public void Divisors_ValidNumbers()
        {
            int n1 = 1;
            int n2 = 10;

            var divisors = new Divisors();

            var expected = new Dictionary<int, List<int>>();
            var actual = divisors.TwoDivisors(n1, n2);

            expected.Add(6, new List<int> { 1, 2, 3, 6 });
            expected.Add(8, new List<int> { 1, 2, 4, 8 });

            Assert.IsTrue(IsDictionariesEqual(expected, actual));
        }

        /// <summary>
        /// When n1 is greater than n2 and n1, n2 > 0
        /// </summary>
        [TestMethod]
        public void Divisors_InvalidNumbers()
        {
            int n1 = 10;
            int n2 = 1;

            var divisors = new Divisors();

            var expected = new Dictionary<int, List<int>>();
            var actual = divisors.TwoDivisors(n1, n2);

            Assert.IsTrue(IsDictionariesEqual(expected, actual));
        }

        /// <summary>
        /// When n1 is greater than n2 and n1, n2 < 0
        /// </summary>
        [TestMethod]
        public void Divisors_NegativeValidNumbers()
        {
            int n1 = -1;
            int n2 = -10;

            var divisors = new Divisors();

            var expected = new Dictionary<int, List<int>>();
            var actual = divisors.TwoDivisors(n1, n2);

            Assert.IsTrue(IsDictionariesEqual(expected, actual));
        }

        /// <summary>
        /// When n1 is less than n2 and n1, n2 <0
        /// </summary>
        [TestMethod]
        public void Divisors_NegativeInvalidNumbers()
        {
            int n1 = -10;
            int n2 = -1;

            var divisors = new Divisors();

            var expected = new Dictionary<int, List<int>>();
            var actual = divisors.TwoDivisors(n1, n2);

            Assert.IsTrue(IsDictionariesEqual(expected, actual));
        }

        /// <summary>
        /// When n1 is equal to n2, but the number of divisors is not equal to four
        /// </summary>
        [TestMethod]
        public void Divisors_EqualNumbers()
        {
            int n1 = 6;
            int n2 = 6;

            var divisors = new Divisors();

            var expected = new Dictionary<int, List<int>>();
            var actual = divisors.TwoDivisors(n1, n2);

            Assert.IsTrue(IsDictionariesEqual(expected, actual));
        }

        /// <summary>
        /// Checks the strict equality of two lists
        /// </summary>
        /// <param name="l1">First list</param>
        /// <param name="l2">Second list</param>
        /// <returns>Equality Test Result</returns>
        bool IsListsEqual(List<int> l1, List<int> l2)
        {
            if (l1.Count == l2.Count)
            {
                for (int i = 0; i < l1.Count; i++)
                    if (l1[i] != l2[i])
                        return false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks the strict equality of two dictionaries
        /// </summary>
        /// <param name="dict1">First dictionary</param>
        /// <param name="dict2">Second dictionary</param>
        /// <returns>Equality Test Result</returns>
        bool IsDictionariesEqual(Dictionary<int, List<int>> dict1, Dictionary<int, List<int>> dict2)
        {
            if (dict1.Count == dict2.Count)
            {
                foreach (var pair in dict1)
                {
                    if (dict2.TryGetValue(pair.Key, out List<int> value))
                    {
                        if (!IsListsEqual(value, pair.Value))
                            return false;   // Require value be equal
                    }
                    else
                        return false;   // Require key be present
                }
                return true;
            }
            return false;
        }
    }
}
