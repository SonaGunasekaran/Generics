using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    //Generic Class 
    public class MaxOfThree <T> where T : IComparable
    {
        //Generic Method
        public static T FindMax(T first, T second, T third)
        {
            //Comparing first value with second and third 
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;

            }
            //Comparing second value with first and third
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            //comparing third value with first and second
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {

                return third;
            }
            else
            {
                Console.WriteLine("All are same");
                return default;
            }

        }
    }
}
