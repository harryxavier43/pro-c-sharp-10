namespace CalcLibTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new CalcLib.Calc();
            Assert.AreEqual(94, c.Add(10, 84));
    
        }
        [TestMethod]
        public void TestMethod2()
        {
            var c = new CalcLib.Calc();
            Assert.AreEqual(84, c.Substract(94, 10));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var c = new CalcLib.Calc();
            Assert.AreEqual(9400, c.Multiply(94,100));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var c = new CalcLib.Calc();
            Assert.AreEqual(9, c.Divide(94, 10));
        }
    }
}
