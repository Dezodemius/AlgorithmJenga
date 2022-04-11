using Jenga;
using NUnit.Framework;

namespace JengaTests
{
  [TestFixture]
  public class Case2Tests
  {
    [Test]
    public void Test1()
    {
      const string message = "Z4D59KLOOAP4248";
      const int expectedIndex = 3;
      var actualIndex = Case2.Do(message, message[expectedIndex], 0, message.Length);
      Assert.AreEqual(expectedIndex, actualIndex);
    }
  }
}