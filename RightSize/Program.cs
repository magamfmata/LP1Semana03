using System;

namespace RightSize
{
    public class Program
    {private static void Main(string[] args)
        {
            foreach (string superior in args)
            {
                if (superior.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                

                if (superior.Length > 3)

                {
                    Console.WriteLine(superior);
                }
            }
        }
    }
}
