//I solemnly swear to do no good!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Booty
{
    class Program
    {
        public static PowerUP brutalDildo;
        public static PowerUP violentStrangulation;

        public static void Main(string[] args)
        {
            brutalDildo = new PowerUP();
            violentStrangulation = new PowerUP();
            brutalDildo.runPowerUp();
            violentStrangulation.runDurationExtender();
            Console.ReadKey();

        }
    }
}
