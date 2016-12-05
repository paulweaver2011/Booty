using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Final_DGM_1600
{
    class PlayerCharacter
    {
        //Invocation
        public PlayerCharacter()
        {

        }
        
        //Character stat variables

        //Life
        int vim = 10;
        //Magic
        int pith = 10;
        //Strength
        int vigor = 10;
        //Endurance
        int grit = 10;
        //Speed
        int gait = 10;
        //Charisma
        int allure = 10;
        //Intelligence
        int wit = 10;
        //Wisdom
        int grasp = 10;
        

        //Equipment variables
        string chestArmor = "nude";
        string headArmor = "nude";
        string legArmor = "nude";
        string shoulderArmor = "nude";
        string footArmor = "nude";
        string fetish = "BDSM";
        string charm = "likely";

        string shield = "none";
        string weapon = "fists";

        /// <summary>
        /// Int Getters and setters
        /// </summary>
        public int Vim { get; set; }
        public int Pith { get; set; }
        public int Vigor { get; set; }
        public int Grit { get; set; }
        public int Gait { get; set; }
        public int Allure { get; set; }
        public int Wit { get; set; }
        public int Grasp { get; set; }

        /// <summary>
        /// String getters and setters
        /// </summary>
        public string ChestArmor { get; set; }
        public string HeadArmor { get; set; }
        public string LegArmor { get; set; }
        public string ShoulderArmor { get; set; }
        public string FootArmor { get; set; }
        public string Fetish { get; set; }
        public string Charm { get; set; }
        public string Shield { get; set; }
        public string Weapon { get; set; }

    }
}
