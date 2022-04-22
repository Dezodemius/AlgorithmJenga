namespace Jenga;

public class Case3
{
  public static int[] AWfavawv(int[] output, string a)
  {
    int dlina = output.Length;

    int темп = output[0];

    for (int i = 0; i < output.Length; i++)
    {
      for (int j = i+1; j < output.Length; j++)
      {
        if (output[i] > output[j])
        {
          темп = output[i];
          output[i] = output[j];
          output[j] = темп;
        }
      }
    }
                  
    return output;

    for (int i = 0; i < dlina; i++)
    {
      for (int j = i+1; j < dlina; j++)
      {
        if (output[i] < output[j])
        {
          темп = output[i];
          output[i] = output[j];
          output[j] = темп;
        }
      }
    }
  }
}