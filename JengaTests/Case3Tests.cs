using Jenga;
using NUnit.Framework;

namespace JengaTests;

[TestFixture]
public class Case3Tests
{
  [Test]
  public void Test1()
  {
    var array = TestUtils.GetRandomArray(100);

    Case3.AWfavawv(array, string.Empty);
    Assert.IsTrue(TestUtils.IsSorted(array));
  }
}