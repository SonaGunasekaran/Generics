using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str1, str2, str3, actual, expected;
            str1 = "Apple"; str2 = "Peach"; str3 = "Banana";
            actual =new MaxOfThree<string>(str1, str2, str3).MaxMethod();
            expected = str1;
            Assert.AreEqual(expected, actual);

            str1 = "Peach"; str2 = "Apple"; str3 = "Banana";
            actual = new MaxOfThree<string>(str1, str2, str3).MaxMethod();
            expected = str2;
            Assert.AreEqual(expected, actual);

            str1 = "Banana"; str2 = "Peach"; str3 = "Apple";
            actual =new MaxOfThree<string>(str1, str2, str3).MaxMethod();
            expected = str3;
            Assert.AreEqual(expected, actual);
        }
        //MaxOfThree among integer
        [TestMethod]
        public void TestMethod2()
        {
            int num1, num2, num3, actual, expected;
            num1 = 45; num2 = 35; num3 = 25;
            actual = new MaxOfThree<int>(num1, num2, num3).MaxMethod();
            expected = num1;
            Assert.AreEqual(expected, actual);
            
            num1 = 35; num2 = 45; num3 = 25;
            actual = new MaxOfThree<int>(num1, num2, num3).MaxMethod();
            expected = num2;
            Assert.AreEqual(expected, actual);
            
            num1 = 25; num2 = 35; num3 = 45;
            actual = new MaxOfThree<int>(num1, num2, num3).MaxMethod();
            expected = num3;
            Assert.AreEqual(expected, actual);
        }
        //MaxOfThree among float
        [TestMethod]
        public void TestMethod3()
        {
            float num1, num2, num3, actual, expected;
            num1 = 4.5F; num2 = 3.5F; num3 = 2.5F;
            actual = new MaxOfThree<float>(num1, num2, num3).MaxMethod() ;
            expected = num1;
            Assert.AreEqual(expected, actual);

            num1 = 3.5F; num2 = 4.5F; num3 = 2.5F;
            actual = new MaxOfThree<float>(num1, num2, num3).MaxMethod() ;
            expected = num2;
            Assert.AreEqual(expected, actual);

            num1 = 2.5F; num2 = 3.5F; num3 = 4.5F;
            actual = new MaxOfThree<float>(num1, num2, num3).MaxMethod();
            expected = num3;
            Assert.AreEqual(expected, actual);
        }
    }
}
