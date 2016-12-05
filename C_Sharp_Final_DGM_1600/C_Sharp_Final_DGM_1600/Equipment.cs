using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Final_DGM_1600
{
    class Equipment
    {
        PlayerCharacter wystan = new PlayerCharacter();

        /// <summary>
        /// Equipment invocation in self
        /// </summary>
        public Equipment()
        {

        }

        //Weapon Stats
        private int weaponPower = 0;
        private int defensePower = 0;
        private int weight = 0;
        private int weaponLength = 0;
        private int critChance = 0;

        /// <summary>
        /// Accuracy
        /// </summary>
        private double missChance = 0.05;

        /// <summary>
        /// Elemental affinity
        /// </summary>
        private string elementalAffinity = "Pure";
    }
}
