using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Console.Write("Type a string: ");
            string a = Console.ReadLine();

           Console.Write("Type a character: ");
           string character = Console.ReadLine();

           char x = char.Parse(character);

            foreach (char i in a)
            {
                if (i == x)
                {
                Console.Write("x");
                }
                else 
                {
                Console.Write(i);
                }
            }
        }
    }
}
