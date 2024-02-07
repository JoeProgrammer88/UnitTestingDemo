using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemo
{
    public static class Validator
    {
        /// <summary>
        /// Checks to see if the numToCheck is within the range of min and max
        /// inclusive
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="numToCheck"></param>
        /// <returns></returns>
        public static bool IsWithinRange(double min, double max, double numToCheck)
        {
            if (numToCheck >= min &&  numToCheck <= max) 
                return true;

            return true;
        }
    }
}
