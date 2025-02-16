using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static bool AssertOnPositiveValue(int value, string property)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{property} value must be positive integer.");
            }

            return true;
        }

        public static bool AssertOnPositiveValue(double value, string property)
        {
            if (value < 0.0)
            {
                throw new ArgumentException($"{property} value must be positive integer.");
            }

            return true;
        }

        public static bool AssertValueInRange(int value, int min, int max, string property) 
        {
            if ( value < min ||  value > max)
            {
                throw new ArgumentException($"{property} value must be more than or equal than {min} and less or equal than {max}.");
            }

            return true;
        }

        public static bool AssertValueInRange(double value, double min, double max, string property)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{property} value must be more than or equal than {min} and less or equal than {max}.");
            }

            return true;
        }
    }
}
