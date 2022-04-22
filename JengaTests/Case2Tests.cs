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
      const string message = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      const int expectedIndex = 19;
      var actualIndex = Case2.Do(message, message[expectedIndex], 0, message.Length);
      Assert.AreEqual(expectedIndex, actualIndex);
    }
  }
}