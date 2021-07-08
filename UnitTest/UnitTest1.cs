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
            string str1,str2,str3, actual, expected;
            str1 = "Apple"; str2 = "Peach"; str3 = "Banana";
            actual = maxOfThree.FindMax(str1,str2,str3);
            expected = str1;
            expected.CompareTo(actual);

            str1 ="Peach" ; str2 = "Apple"; str3 = "Banana";
            actual = maxOfThree.FindMax(str1, str2, str3);
            expected = str1;
            expected.CompareTo(actual);

            str1 = "Banana" ; str2 = "Peach"; str3 = "Apple";
            actual = maxOfThree.FindMax(str1, str2, str3);
            expected = str1;
            expected.CompareTo(actual);




        }
    }
}
