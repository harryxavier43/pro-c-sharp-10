using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CalcProjects.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Test_MainMethod_Execution1()
    {
        // Arrange: Set up string writers to capture console output if needed

        // Act: Call the Main method of Program.cs
        int result = Calc.Cs.Program.Main();

        // Assert: Verify expected behavior or console outputs
        Assert.AreEqual(94, result);
    }

    [TestMethod]
    public void Test_MainMethod_Execution2()
    {
        // Arrange: Set up string writers to capture console output if needed

        // Act: Call the Main method of Program.cs
        int result = Calc.Cs.Program.Main();

        // Assert: Verify expected behavior or console outputs
        Assert.AreEqual(94, result);
    }
}
