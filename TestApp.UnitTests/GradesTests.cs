using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4.00, "Very Good")]
    [TestCase(4.50, "Excellent")]
    [TestCase(5.50, "Invalid!")]

    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange is TestCases in this scenario

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(-2.0, "Invalid!")]
    [TestCase(0, "Invalid!")]
    [TestCase(10, "Invalid!")]
    [TestCase(double.PositiveInfinity, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange is TestCases in this scenario

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
