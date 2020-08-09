using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NormalNumbers()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(1);
            Assert.AreEqual("1", num);
            num = fb.NumberTester(2);
            Assert.AreEqual("2", num);
            num = fb.NumberTester(4);
            Assert.AreEqual("4", num);
        }


        [TestMethod]
        public void MultplesOf3()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(3);
            Assert.AreEqual("fizz", num);
            num = fb.NumberTester(9);
            Assert.AreEqual("fizz", num);
            num = fb.NumberTester(123);
            Assert.AreEqual("fizz", num);
        }
        [TestMethod]
        public void MultplesOf5()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(5);
            Assert.AreEqual("buzz", num);
            num = fb.NumberTester(20);
            Assert.AreEqual("buzz", num);
            num = fb.NumberTester(200);
            Assert.AreEqual("buzz", num);
        }
        [TestMethod]
        public void MultplesOf3and5()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(15);
            Assert.AreEqual("fizz buzz", num);
            num = fb.NumberTester(45);
            Assert.AreEqual("fizz buzz", num);
            num = fb.NumberTester(315);
            Assert.AreEqual("fizz buzz pop", num);  // was 315 overlooked as being multiple of 3-5 and 7 or intentional
        }

        [TestMethod]
        public void MultplesOf7()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(7);
            Assert.AreEqual("pop", num);
            num = fb.NumberTester(28);
            Assert.AreEqual("pop", num);
            num = fb.NumberTester(77);
            Assert.AreEqual("pop", num);
        }
        [TestMethod]
        public void MultplesOf3and7()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(21);
            Assert.AreEqual("fizz pop", num);
            num = fb.NumberTester(63);
            Assert.AreEqual("fizz pop", num);
            num = fb.NumberTester(126);
            Assert.AreEqual("fizz pop", num);
        }

        [TestMethod]
        public void MultplesOf5and7()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(35);
            Assert.AreEqual("buzz pop", num);
            num = fb.NumberTester(70);
            Assert.AreEqual("buzz pop", num);
            num = fb.NumberTester(140);
            Assert.AreEqual("buzz pop", num);
        }
        [TestMethod]
        public void MultplesOf3and5and7()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(105);
            Assert.AreEqual("fizz buzz pop", num);
            num = fb.NumberTester(210);
            Assert.AreEqual("fizz buzz pop", num);
            num = fb.NumberTester(315);
            Assert.AreEqual("fizz buzz pop", num);
        }

        [TestMethod]
        public void MultplesOf2CustomSubstitution()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(1, true, "fuzz");
            Assert.AreEqual("1", num);
            num = fb.NumberTester(2, true, "fuzz");
            Assert.AreEqual("fuzz", num);
            num = fb.NumberTester(8, true, "fuzz");
            Assert.AreEqual("fuzz", num);
        }

        [TestMethod]
        public void MultplesOf2and3CustomSubstitution()
        {
            FizzBuzzTester fb = new FizzBuzzTester();
            var num = fb.NumberTester(4, true, "fuzz", "bizz");
            Assert.AreEqual("fuzz", num);
            num = fb.NumberTester(9, true, "fuzz", "bizz");
            Assert.AreEqual("bizz", num);
            num = fb.NumberTester(12, true, "fuzz", "bizz");
            Assert.AreEqual("fuzz bizz", num);
        }


    }
}
