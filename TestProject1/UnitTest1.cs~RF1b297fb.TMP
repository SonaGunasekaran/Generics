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
            string actual, expected;
            string[] stringArray = { "Apple", "Peach", "Banana" };
            actual =new MaxOfThree<string>(stringArray).MaxMethod();
            expected = "Apple";
            Assert.AreEqual(expected, actual);
        }
        //MaxOfThree among integer
        [TestMethod]
        public void TestMethod2()
        {
            int actual, expected;
            int[] intArray = { 20, 15, 40, 60, 25 };
            actual = new MaxOfThree <int>(intArray).MaxMethod();
            expected = 60;
            Assert.AreEqual(expected, actual);
            
        }
        //MaxOfThree among float
        [TestMethod]
        public void TestMethod3()
        {

            float actual, expected;
            float[] floatArray = { 2.0F, 1.5F, 4.0F, 6.0F, 2.5F };
            actual = new MaxOfThree <float>(floatArray).MaxMethod();
            expected = 6.0F;
            Assert.AreEqual(expected, actual);
        }
    }
}
