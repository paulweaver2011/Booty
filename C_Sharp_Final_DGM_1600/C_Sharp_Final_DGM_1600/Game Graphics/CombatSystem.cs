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

        public CombatSystem()
        {

        }

        private int weaponPower = 0;
        private int armorStrength = 0;
        private int armorValue = 0;

        public int FindPlayerDamage(int str, int wpnPwr)
        {
            double playerDamage = str + weaponPower;
            return weaponPower;
        }

        public int FindPlayerDefense(int endr, int armStr)
        {
            double armorStrength = wystan.Grit + armorValue;
            return (int)armorStrength;
        }

        public int FindMonsterDamage(int str, int wpnPwr)
        {
            double playerDamage = str + weaponPower;
            return weaponPower;
        }

        public int FindMonsterDefense(int endr, int armStr)
        {
            double armorStrength = wystan.Grit + armorValue;
            return (int)armorStrength;
        }


    }
}
