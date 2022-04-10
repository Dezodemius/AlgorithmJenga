using System;
using System.Collections.Generic;
using System.Linq;

namespace JengaTests
{
  public static class TestUtils
  {
    public static int[] GetRandomArray(int n)
    {
      var buffer = new byte[100];
      new Random().NextBytes(buffer);
      var array = buffer.Select(i => (int)i).ToArray();
      return array;
    }

    public static bool IsSorted(IReadOnlyList<int> array, bool isReverse = false)
    {
      for (var i = 0;  i < array.Count - 1; i++)
      {
        if (isReverse)
        {
          if (array[i] < array[i + 1])
            return false;
        }
        else
        {
          if (array[i] > array[i + 1])
            return false;
        }
      }

      return true;
    }
  }
}