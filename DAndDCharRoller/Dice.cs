using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    class Dice
    {
        public static int MAX = 6;

        private int DiceRoll()
        {
            Random rand = new Random();
            return rand.Next(MAX) + 1;
        }
    }
}