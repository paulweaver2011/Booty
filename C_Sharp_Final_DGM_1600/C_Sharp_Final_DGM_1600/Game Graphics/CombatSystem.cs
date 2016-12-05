using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Final_DGM_1600
{
    class CombatSystem
    {
        PlayerCharacter wystan = new PlayerCharacter();

        // Invocation
        public CombatSystem()
        {

        }

        private int weaponPower = 0;
        private int armorStrength = 0;
        private int armorValue = 0;

        /// <summary>
        /// Finds player damage
        /// </summary>
        /// <param name="str"></param>
        /// <param name="wpnPwr"></param>
        /// <returns></returns>
        public int FindPlayerDamage(int str, int wpnPwr)
        {
            double playerDamage = str + weaponPower;
            return weaponPower;
        }

        /// <summary>
        /// Finds player defense
        /// </summary>
        /// <param name="endr"></param>
        /// <param name="armStr"></param>
        /// <returns></returns>
        public int FindPlayerDefense(int endr, int armStr)
        {
            double armorStrength = wystan.Grit + armorValue;
            return (int)armorStrength;
        }

        /// <summary>
        /// Find monster damage
        /// </summary>
        /// <param name="str"></param>
        /// <param name="wpnPwr"></param>
        /// <returns></returns>
        public int FindMonsterDamage(int str, int wpnPwr)
        {
            double playerDamage = str + weaponPower;
            return weaponPower;
        }

        /// <summary>
        /// Find monster defense
        /// </summary>
        /// <param name="endr"></param>
        /// <param name="armStr"></param>
        /// <returns></returns>
        public int FindMonsterDefense(int endr, int armStr)
        {
            double armorStrength = wystan.Grit + armorValue;
            return (int)armorStrength;
        }


    }
}
