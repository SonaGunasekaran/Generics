using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   
        //Generic Class 
        public class MaxOfThree<T> where T : IComparable
        {
        //Generic Method
            public T[] inputArray;
            public MaxOfThree(T[]inputArray)
            {
               this.inputArray = inputArray;
            }
            //Sorting the input array
            public static T[] SortArray(T[]inputArray)
            {
                Array.Sort(inputArray);
                return inputArray;
            }
            //Finding the maximum value in the array
            public static T FindMax(T[]inputArray)
            {
                 var sortedValues = SortArray(inputArray);
                 return sortedValues[sortedValues.Length - 1];
            }
            public T MaxMethod()
            {
                  T max = MaxOfThree<T>.FindMax(this.inputArray);
                  return max;
            }
            public  void PrintValue()
            {
                var max = FindMax(this.inputArray);
                Console.WriteLine("Maximum value is : " +max);
            }

        }
}

