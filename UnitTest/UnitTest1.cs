using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        MaxOfThree maxOfThree;

        public void UnitTest()
        {
            maxOfThree= new MaxOfThree();
        }

        [TestMethod]
        public void TestMethod1()
        { 
            float num1, num2, num3, actual, expected;
            num1 = 4.5F; num2 = 3.5F; num3 = 2.5F;
            actual = maxOfThree.FindMax(num1, num2, num3);
            expected = num1;
            expected.CompareTo(actual);

            num1 = 3.5F; num2 = 4.5F; num3 = 2.5F;
            actual = maxOfThree.FindMax(num1, num2, num3);
            expected = num2;
            expected.CompareTo(actual);

            num1 = 2.5F; num2 = 3.5F; num3 = 4.5F;
            actual = maxOfThree.FindMax(num1, num2, num3);
            expected = num1;
            expected.CompareTo(actual);
        }
    }
}
