using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poots_And_The_Noodle_Caboodle
{
    class Program
    {
        const int tenNum = 10;
        WeaponBase unarmed = new WeaponBase();

        static bool weaponEquipped = false;
        static string currentWeapon = "unarmed";
        

        /// <summary>
        /// Instantiation of the game Object
        /// </summary>
        public static Game myGame = new Game();

        static void Main(string[] args)
        {
            myGame.score = tenNum;

            Console.WriteLine("Phew... dat was a close call. I almost brained you, spiky haired little punk!\n\n\nYou best tell me yo name, muthafucka!");
            myGame.name = Console.ReadLine();

            Console.WriteLine($"Dats right, {myGame.name}! Now we have a understandin'!\n");

            Console.ReadKey();

            //Weapon Equipment check. Determines what weapon is equipped, and equips chosen weapon based on choices
            do
            {
                Console.WriteLine($"You best be weapon'n up, lil' bitchass! Pick a weapon... \n\n(Lovegun, Rape Tentacle, or Violent Triangulation");

                currentWeapon = Console.ReadLine().ToLower();

                if (currentWeapon == "lovegun")
                {
                    Console.WriteLine($"You have equipped {currentWeapon}.\n");

                    weaponEquipped = true;

                    Console.WriteLine($"Now ya gotta {currentWeapon}, chump! Let's move out!\n");
                    
                    Console.ReadKey();

                }
                else if (currentWeapon == "rape tentacle")
                {
                    Console.WriteLine($"You have equipped {currentWeapon}.\n");

                    weaponEquipped = true;

                    Console.WriteLine($"Dayum, son! You a sickass mutha-fucka! Let's go do sumthin' with you sickass {currentWeapon}, hentai bastard!k\n");


                    Console.ReadKey();

                }
                else if (currentWeapon == "violent triangulation")
                {
                    Console.WriteLine($"You have equipped {currentWeapon}.\n");

                    weaponEquipped = true;

                    Console.WriteLine($"Nice choice, brutha! I prefer a little bitta {currentWeapon} myself! Now we bout'ta go get some!\n");

                    Console.ReadKey();

                }
                else

                    Console.WriteLine("Try again, you dumbasss muthafuckin' punkass bitch! \n\nMaybe type what I fuckin' told you!!");

            } while (weaponEquipped == false);
            
            Console.ReadKey();
        }
    }
}
