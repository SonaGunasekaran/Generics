using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    class MaxOfThree
    {
        public float FindMax(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;

            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {

                return num3;
            }
            else
            {
                Console.WriteLine("All are having same number");
                return 0;
            }

        }
    }
}
