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

            Console.WriteLine($"Dats right, {myGame.name}! Now we have a understandin'!");

            Console.WriteLine($"You best be weapon'n up, lil' bitchass! Pick a weapon... (Lovegun, Rape Tentacle, or Violent Triangulation");

            weaponEquipped = true;

            currentWeapon = Console.ReadLine();
            Console.WriteLine($"You have equipped {currentWeapon}.");

            Console.WriteLine($"Now ya gotta {currentWeapon}, chump! Let's move out!");

            if (weaponEquipped == true && (currentWeapon == "Lovegun" || currentWeapon == "lovegun"))
            {

            }
            else if (weaponEquipped == true && (currentWeapon == "Rape Tentacle" || currentWeapon == "rape tentacle"))
            {

            }
            else if (weaponEquipped == true && (currentWeapon == "Violent Triangulation" || currentWeapon == "violent triangulation"))
            {

            }
            else

                Console.WriteLine("Try again, you dumbasss muthafuckin' punkass bitch! Maybe type what I fuckin' told you!!");


            Console.ReadKey();
        }
    }
}
