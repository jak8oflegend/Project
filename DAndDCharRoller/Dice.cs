using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    /// <summary>
    /// handles creation of the 6 sided die
    /// </summary>
    class Dice
    {
        private static Random rand;
        public Dice()
        {

            DiceRoll();
        }
        static Dice()
        {
            rand = new Random();

        }
        public Byte Value { get; private set; }
        public Byte DiceRoll()
        {
            int DiceValue = 7;///value of dice +1 due to non inclusive random
            int MinDiceValue = 1;///min value is inclusve
             Value =  (Byte)rand.Next(MinDiceValue,DiceValue);

            return Value; 
            
        }
        
        
    }

}