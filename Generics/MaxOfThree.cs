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
            
            public static T[] SortArray(T[]inputArray)
            {
                Array.Sort(inputArray);
                return inputArray;
            }
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

        }
}

