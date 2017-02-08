using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTestAsp46.Services
{
    class Triangle
    {
        /// <summary>
        /// Calculates a triangle given 3 integer inputs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Returns a stirng representation of the triagel type, or 'Invalid inputs' if not compatible</returns>
        public string calculateTriangle(int a, int b, int c)
        {
            if (checkValue(a) && checkValue(b) && checkValue(c))
            {
                int[] values = orderedValues(new int[] { a, b, c });
                if (checkRules(values)) { return calculateType(values); }
            }
            return "Invalid inputs";
        }

        /// <summary>
        /// Check that values are positive numbers
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private bool checkValue(int val)
        {
            if (val <= 0) { return false; }
            return true;
        }

        /// <summary>
        /// Sort array in ascending order
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private int[] orderedValues(int[] values)
        {
            return values.OrderBy(v => v).ToArray();
        }

        /// <summary>
        /// Checks if the values in the array follows the rules for a triangle
        /// 
        /// c minus b < a < c plus b
        /// c < b < a
        /// </summary>
        /// <param name="orderedVal"></param>
        /// <returns></returns>
        private bool checkRules(int[] orderedVal)
        {
            if (orderedVal[0] <= orderedVal[1] && orderedVal[1] <= orderedVal[2])
            {
                if ((orderedVal[2] - orderedVal[0]) < orderedVal[1] && orderedVal[1] < (orderedVal[2] + orderedVal[0]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Takes an array of integeres and checks for the type of triangle
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private string calculateType(int[] values)
        {
            if (values[0] == values[1] && values[0] == values[2]) { return "Equilateral triangle"; }
            if (values[0] == values[1] || values[0] == values[2] || values[1] == values[2]) { return "Isosceles triangle"; }
            // if none of the above is the case then return Scalene triangle
            return "Scalene triangle";
        }
    }
}
