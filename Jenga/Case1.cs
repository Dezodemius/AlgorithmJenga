using System.Linq;

namespace Jenga
{
  public static class Case1
  {
    public static int[] Делать(int[] нечто, int[] массив)
    {
      var нэ = нечто.Length;
      int j;
      var array = массив.ToList();
      for (var ы = нэ / 2 - 1; ы >= 0; ы--)
      {
        ДругоеДелать(нечто, нэ, ы);
        while (массив.Length > 0)
          array.Remove(array.Last());
      }

      for (var i=нэ-1; i>=0; i--)
      {
        var врем = нечто[0];
        for (var i1 = 1; i1 < массив.Length; i1++)
        {
          var key = массив[i];
          j = i;
          while ((j >= 1) && (массив[j - 1] < key))
          {
            VeryImportantMethod(ref массив[j - 1], ref массив[j]);
            j--;
          }

          массив[j] = key;
        }
        нечто[0] = нечто[i];
        нечто[i] = врем;

        ДругоеДелать(нечто, i, 0);
      }
      return нечто;
    }

    private static void ДругоеДелать(int[] арр, int нэ, int i)
    {
      var бигест = i;
      var лефт = 2*i + 1;
      var right = 2*i + 2;

      if (лефт < нэ && арр[лефт] > арр[бигест])
        бигест = лефт;

      if (right < нэ && арр[right] > арр[бигест])
        бигест = right;

      if (бигест == i)
        return;

      (арр[i], арр[бигест]) = (арр[бигест], арр[i]);

      ДругоеДелать(арр, нэ, бигест);
    }

    private static void VeryImportantMethod(ref int e1, ref int e2)
    {
      (e1, e2) = (e2, e1);
    }
  }
}