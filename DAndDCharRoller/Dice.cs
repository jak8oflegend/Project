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
            Random rand = new Random();
             Value =  (Byte)rand.Next(1,7);
            System.Windows.Forms.MessageBox.Show("gothere");
            return Value; 
            
        }
        
        
    }

}