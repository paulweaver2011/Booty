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

        public string weapon = "";

        /// <summary>
        /// Instantiation of the game Object
        /// </summary>
        public static Game myGame = new Game();

        static void Main(string[] args)
        {
            myGame.score = tenNum;

            Console.WriteLine("Phew... dat was a close call. I almost brained you, spiky haired little punk!\nYou best tell me yo name, muthafucka!");
            myGame.name = Console.ReadLine();

            Console.WriteLine($"Dats right, {myGame.name}! Now we have a understandin'!");

            Console.WriteLine($"You best be weapon'n up, lil' bitchass! Pick a weapon... (Lovegun, Rape Tentacle, or Violent Triangulation");

            if (WeaponBase == "Lovegun" || "lovegun")
            {

            }

            Console.ReadKey();
        }
    }
}
