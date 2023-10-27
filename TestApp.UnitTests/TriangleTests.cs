using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // TODO: Write your test here...
        // Arrange
        int input = 0;
        // Act
        string output = Triangle.PrintTriangle(input);
        // Assert
        Assert.AreEqual("", output);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        int input = 3;
        string expected = 
              "1" + Environment.NewLine +
             "1 2" + Environment.NewLine +
             "1 2 3" + Environment.NewLine +
             "1 2" + Environment.NewLine +
             "1";

        string output = Triangle.PrintTriangle(input);
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int input = 5;
        string expected =
              "1" + Environment.NewLine +
             "1 2" + Environment.NewLine +
             "1 2 3" + Environment.NewLine +
             "1 2 3 4" + Environment.NewLine +
             "1 2 3 4 5" + Environment.NewLine +
             "1 2 3 4" + Environment.NewLine +
             "1 2 3" + Environment.NewLine +
             "1 2" + Environment.NewLine +
             "1";

        string output = Triangle.PrintTriangle(input);
        Assert.AreEqual(expected, output);
    }
}
