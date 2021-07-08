using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    class MaxOfThree
    {
        public string FindMax(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0)
            {
                return str1;

            }
            else if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0)
            {
                return str2;
            }
            else if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0)
            {

                return str3;
            }
            else
            {
                Console.WriteLine("All are same");
                return " ";
            }

        }
    }
}
