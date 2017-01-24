using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
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
             Value =  (Byte)rand.Next(1,7);

            return Value; 
            
        }
        
        
    }

}