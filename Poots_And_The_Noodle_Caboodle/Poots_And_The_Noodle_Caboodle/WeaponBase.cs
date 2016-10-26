using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poots_And_The_Noodle_Caboodle
{
    class WeaponBase
    {
        public WeaponBase()
        {
            int wpnDamage = 0;
            int wpnSpeed = 0;
            int wpnWeight = 0;
            string wpnType = "";
            double critChance = 0.00;

        }

        public void Fire()
        {
            Console.WriteLine("Yall goin' die, muthafuckas! KA-BLAM!");
        }

        public void Fondle()
        {
            Console.WriteLine("Let the rape be upon you! Tentacle monster! I choose you!");
        }

        public void AggressiveGeometry()
        {
            Console.WriteLine("Prepare... to be square!! Mathmatical!");
        }
    }
}
