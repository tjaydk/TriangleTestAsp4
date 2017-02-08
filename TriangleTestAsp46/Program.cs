using System;
using TriangleTestAsp46.Services;

namespace TriangleTestAsp46
{
    class Program
    {
        /// <summary>
        /// Takes three side lenghts and creates a triangle. 
        /// - If the three sides are alike its a equalsided triangle.
        /// - If the two sides are alike and the last is shorter its a equallegged triangle
        /// - If the two sidelenghts combined is longer than the longest its a stumb or pointy triangle
        /// - other caess should not be accepted !!!
        /// 
        /// The inequality rule: c minus b < a < c plus b
        /// Rules for sidelenghts: c < b < a
        /// 
        ///                                         TESTCASES
        /// =====================================================================================================                                        
        ///     INPUT           EXP. OUTPUT         (OUTPUT) WAIT WITH THIS             Test type
        /// ---------------------------------------------------------------------
        /// |   3, 3, 3     |   Equilateral     |                               |       Correct type of triangle
        /// ---------------------------------------------------------------------
        /// |   2, 2, 1     |   Isosceles       |                               |       Correct type of triangle
        /// ---------------------------------------------------------------------
        /// |   3, 4, 5     |   Scalene         |                               |       Correct type of triangle
        /// ---------------------------------------------------------------------
        /// |   a, b, c     |   invalid input   |                               |       Only int numbers allowed
        /// ---------------------------------------------------------------------
        /// |   -1, 3, 3    |   invalid input   |                               |       Only positive values
        /// ---------------------------------------------------------------------
        /// |   0, 3, 3     |   invalid input   |                               |       No zero values 
        /// ---------------------------------------------------------------------
        /// |   1, 3, 6     |   invalid input   |                               |       Inequality test
        /// ---------------------------------------------------------------------
        /// |   max+1, 3, 6 |   invalid input   |                               |       Not an integer value
        /// ---------------------------------------------------------------------
        /// =====================================================================================================

        private static int a, b, c;
        private static Triangle t = new Triangle();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "THE TRIANGLE v. 0.1 \n" +
                    "This program takes 3 integer values as side lengths and calculates if they make up a triangle, \n" +
                    "if they do, then it will return the type of triangle created. \n\n" +
                    "!!NB - Only integer values are accepted.\n" +
                    "========================================\n" +
                    "Rules of a triangle:\n" +
                    "c-b < a < c+b\n" +
                    "c < b < a\n\n" +
                    "Press any key to start..."
                    );
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Input value a:");
                a = getInput();

                Console.WriteLine("Input value b:");
                b = getInput();

                Console.WriteLine("Input value c:");
                c = getInput();

                Console.Clear();
                Console.WriteLine("Calculating...");
                string triangle = t.calculateTriangle(a, b, c);
                Console.Clear();

                Console.WriteLine(triangle);
                Console.WriteLine("\nPress Esc to exit, or any key to try again");
                if (Console.ReadKey().Key == ConsoleKey.Escape) { Environment.Exit(0); }
            }
        }

        public static int getInput()
        {
            bool takeInput = true;
            int val;
            while (takeInput)
            {
                if (int.TryParse(Console.ReadLine(), out val)) { return val; }
                else { Console.WriteLine("Invalid input, please try again:\n"); }
            }
            return 0;
        }
    }
}
