using System;
using System.Data.Common;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            Weapons weapon = Enum.Parse<Weapons>(args[1]);
            string weaponstring = weapon.ToString();
            Weapons CurrentWeapon = 0;

            if (weaponstring == "SilverBullet") 

                {
                    CurrentWeapon |= Weapons.SilverBullet;
                    return CurrentWeapon;
                }

            if (weaponstring == "Garlic") 

                {
                    CurrentWeapon |= Weapons.Garlic;
                    return CurrentWeapon;
                }

            if (weaponstring == "HolyWater") 

                {
                    CurrentWeapon |= Weapons.HolyWater;
                    return CurrentWeapon;
                }

            return CurrentWeapon;
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            bool survives = true;

            if ((weapons & Weapons.SilverBullet) == Weapons.SilverBullet)

            {
                if (enemy == EnemyType.Zombie || enemy == EnemyType.Werewolf)

                {
                    survives = false;
                    return survives;
                }

                else

                {
                
                    survives = true;
                    return survives;
                }

            }

            if ((weapons & Weapons.Garlic) == Weapons.Garlic)

            {
                if (enemy == EnemyType.Vampire)

                {
                    survives = false;
                    return survives;
                }

                else

                {
                    survives = true;
                    return survives;
                }

            }

            if ((weapons & Weapons.HolyWater) == Weapons.HolyWater)

            {
                if (enemy == EnemyType.Vampire || enemy == EnemyType.Ghost)

                {
                    survives = false;
                    return survives;
                }

                else

                {
                    survives = true;
                    return survives;
                }

            }

            return survives;

        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)

        {
            if (survives)

            {
                Console.WriteLine($"{enemy} survives");
            }

            else
            
            {
                Console.WriteLine($"{enemy} dies");
            }
        }
    }
}