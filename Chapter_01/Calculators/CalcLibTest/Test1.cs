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
    }
}
