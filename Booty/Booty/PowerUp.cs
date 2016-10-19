using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booty
{
    class PowerUP
    {
        private int power = 10;
        private double duration = 2.0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PowerUP()
        {

        }

        /// <summary>
        /// Runs the power up operation
        /// </summary>
        public void runPowerUp()
        {
            Console.WriteLine("You are now dildo-ified! Zis ist vunderbaru!");
        }

        public void runDurationExtender()
        {
            Console.WriteLine("Your duration has been extended! If your duration lasts longer than four hours, please consult your doctor immediately");
        }

    }
}
