using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCSharpApp.Tests;
[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void TestAdd()
    {
        Assert.AreEqual(5, Calculator.Add(2, 3));
    }
}