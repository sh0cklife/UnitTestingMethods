using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        int input = 0;
        int output = Factorial.CalculateFactorial(input);
        Assert.AreEqual(1, output);

    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        int input = 4;
        int output = Factorial.CalculateFactorial(input);
        Assert.AreEqual(24, output);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException() 
    {
        // Arrange
        int input = -4;
        // Act + Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
