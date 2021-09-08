using System;
using System.Collections.Generic;
using System.Linq;

namespace FindDivisorsLibrary
{
    /// <summary>
    /// Class for finding divisors of numbers
    /// </summary>
    public class Divisors
    {
        /// <summary>
        /// In a given interval (n1, n2), where n2 > n1, 
        /// find a list of numbers that have exactly two 
        /// divisors other than base divisors.
        /// </summary>
        /// <param name="n1">First number of interval</param>
        /// <param name="n2">Second number of interval</param>
        /// <returns></returns>
        public Dictionary<int, List<int>> TwoDivisors(int n1, int n2)
        {
            var result = new Dictionary<int, List<int>>();

            AddDivisors(n1, n2, result);

            return result;
        }

        /// <summary>
        /// Adds divisors of numbers to a dictionary.
        /// The number of divisors of the number must
        /// be equal to four, since if there are always
        /// two basic divisors (the number itself and 
        /// the one), and by the condition of the problem 
        /// there should be two more divisors.
        /// </summary>
        /// <param name="n1">First number of interval</param>
        /// <param name="n2">Second number of interval</param>
        /// <param name="result"></param>
        private void AddDivisors(int n1, int n2, Dictionary<int, List<int>> result)
        {
            for (int i = n1; i < n2; i++)
            {
                var divisors = DivisorsOfNumber(i);

                if (divisors.Count == 4)
                    result.Add(i, divisors);
            }
        }

        /// <summary>
        /// Finds all divisors of a number
        /// </summary>
        /// <param name="n">The number that will decompose into divisors</param>
        /// <returns>List of integer divisors of a number</returns>
        private List<int> DivisorsOfNumber(int n)
        {
            var resut = new List<int>();

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    resut.Add(i);

                    if (i != n / i)
                        resut.Add(n / i);
                }
            }

            resut.Sort();

            return resut;
        }

        /// <summary>
        /// Makes a dictionary a string
        /// </summary>
        /// <param name="dict">Dictionary for printing</param>
        public string StrDict(Dictionary<int, List<int>> dict)
        {
            string result = "";

            foreach (var pair in dict.ToList())
            {
                var values = "";

                foreach (var item in pair.Value)
                {
                    values += item;
                    values += " ";
                }

                result += $"{pair.Key}: {values}";
                result += Environment.NewLine;
            }

            return result;
        }
    }
}
