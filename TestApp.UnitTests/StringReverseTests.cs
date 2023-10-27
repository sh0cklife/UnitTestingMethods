using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        //const string test = "asd";
        string input = "";
        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = ("a");
        string actual = StringReverse.Reverse(input);
        Assert.AreEqual("a", actual);
        Assert.AreEqual(1, actual.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = ("jkl");
        string result = StringReverse.Reverse(input);
        Assert.AreEqual(input.Length, result.Length);
        Assert.AreEqual("lkj", result);
    }
}
