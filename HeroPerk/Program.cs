using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string perk = args[0].Trim().ToLower();

            Perks playerPerks = 0;

            int checkA = 0; 
            int checkW = 0; 
            int checkS = 0; 
            int checkD = 0;

            foreach (char ch in perk)
            {
                if (ch != 'w' && ch != 'a' && ch != 's' && ch != 'd')
                {
                    Console.WriteLine("!Unknown perk!");
                    return;
                }
                
                switch (ch)
                {
                    case 'w': checkA++; break;
                    case 'a': checkW++; break;
                    case 's': checkS++; break;
                    case 'd': checkD++; break;
                }
            }

            if (checkA % 2 != 0) playerPerks |= Perks.WarpShift;
            if (checkW % 2 != 0) playerPerks |= Perks.AutoHeal;
            if (checkS % 2 != 0) playerPerks |= Perks.Stealth;
            if (checkD % 2 != 0) playerPerks |= Perks.DoubleJump;

            if (playerPerks != 0)
            {
                Console.WriteLine(playerPerks);

                if ((playerPerks & Perks.Stealth) != 0 && 
                (playerPerks & Perks.DoubleJump) != 0)
                
                {
                    Console.WriteLine("!Silent Jumper!");
                }

                if ((playerPerks & Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
            else
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}