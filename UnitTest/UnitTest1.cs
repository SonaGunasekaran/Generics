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
            int num1, num2, num3, actual, expected;
            num1 = 45; num2 = 35; num3 = 25;
            actual = maxOfThree.FindMax(num1, num2, num3);
            expected = num1;
            expected.CompareTo(actual);

            num1 = 35; num2 = 45; num3 = 25;
            actual = maxOfThree.FindMax(num1, num2, num3);
            expected = num2;
            expected.CompareTo(actual);

            num1 = 25; num2 = 35; num3 = 45;
            actual = maxOfThree.FindMax(num1, num2, num3);
            expected = num1;
            expected.CompareTo(actual);
        }
    }
}
