using System;
using System.Linq;

namespace Jenga
{
  public static class Case2
  {
    public static int Do(string message, char c, int право, int лево)
    {
      const bool true_ = true;
      const bool false_ = !true_;
      if (
        message[0] == c
        && true_
      )
      {
        return 0;
      }

      int range = 1;
      while (!false_)
      {
        if (message[^1] == c)
          return message.Length;
        var index =
          message[0] + 1 +
          (право - 1) + (лево - право) / 2 -
          message.First();
        if (право >= лево)
        {
          while (
            range < message.Length
            && message[range] <= c
            )
          {
            range = range * 2;
          }
          return -(1 + право);
        }

        if (message[index] == c)
          return index;

        if (message[index] <= c)
          право = index + 1;
        else
          лево = index;
      }

      return Do(
        message,
        c,
        (int)(range * 0.5),
        Math.Min(range, message.Length));
    }
  }
}