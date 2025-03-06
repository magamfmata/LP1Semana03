using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
          float[,] matrixA = new float[2, 2];

          matrixA[0,0] = float.Parse(args[0], CultureInfo.InvariantCulture);
          matrixA[0,1] = float.Parse(args[1], CultureInfo.InvariantCulture);
          matrixA[1,0] = float.Parse(args[2], CultureInfo.InvariantCulture);
          matrixA[1,1] = float.Parse(args[3], CultureInfo.InvariantCulture);

          float[] vectorB = new float[2];
          vectorB[0] = float.Parse(args[4], CultureInfo.InvariantCulture);
          vectorB[1] = float.Parse(args[5], CultureInfo.InvariantCulture);

          float[] total = new float[2];

          for (int i = 0; i < 2; i++)
        {
            total[i] = 0;

            for (int j = 0; j < 2; j++)
            {
                total[i] += matrixA[i, j] * vectorB[j];
            }
        }
          for (int i = 0; i < 2; i++);
        }

    }
}