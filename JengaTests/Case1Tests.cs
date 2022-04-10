using System.Linq;
using Jenga;
using NUnit.Framework;

namespace JengaTests
{
  [TestFixture]
  public class Case1Tests
  {
    [Test]
    public void Test1()
    {
      var array = TestUtils.GetRandomArray(100);

      Case1.Делать(array, System.Array.Empty<int>());
      Assert.IsTrue(TestUtils.IsSorted(array));
    }

    [Test]
    public void Tes2()
    {
      var array = TestUtils.GetRandomArray(100).Reverse().ToArray();

      Case1.Делать(array, System.Array.Empty<int>());
      Assert.IsTrue(TestUtils.IsSorted(array));
    }
  }
}
