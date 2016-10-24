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

        private WeaponBase loveGun = new WeaponBase();

        public string name = "";
        public int score = 0;
    }
}
