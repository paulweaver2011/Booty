using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poots_And_The_Noodle_Caboodle
{
    class Game
    {
        public Game()
        {
            loveGun.Fire();
        }

        public WeaponBase unarmed = new WeaponBase();
        public WeaponBase loveGun = new WeaponBase();
        public WeaponBase rapeTentacle = new WeaponBase();
        public WeaponBase violentTriangulation = new WeaponBase();

        public PowerUp virility = new PowerUp();

        public string name = "";
        public int score = 0;
    }
}
