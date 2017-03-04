using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAndDCharRoller;

namespace DAndDCharRoller
{/// <summary>
/// handles dice rolls currently only 4dg drop 1 is porgrammed
/// </summary>
    public class statrolldice
    {
        public static Byte DiceRollforstats()
        {
            List<byte> dicearray = new List<byte>(4);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            //for (Byte i = 0; i < 4; i++)
            //{
            //   dicearray[i] = (new Dice());
            //}
            Byte lowest = Convert.ToByte(dicearray[0]);
            Byte lowestindex = 0;
            for (Byte i = 1; i < 4; i++)
            {
                if (lowest > Convert.ToByte(dicearray[i]))
                {
                    lowest = Convert.ToByte(dicearray[i]);
                    lowestindex = i;
                }
            }
            dicearray.RemoveAt(lowestindex);
            Byte sum = Convert.ToByte(dicearray[0]);
            sum += Convert.ToByte(dicearray[1]);
            sum += Convert.ToByte(dicearray[2]);
            return sum;
        }

        public static Byte DiceRollforstats3d6()
        {
            List<byte> dicearray = new List<byte>(3);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            Byte sum = Convert.ToByte(dicearray[0]);
            sum += Convert.ToByte(dicearray[1]);
            sum += Convert.ToByte(dicearray[2]);
            return sum;
        }

        public static Byte DiceRollforstats5d6()
        {
            List<byte> dicearray = new List<byte>(5);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            Byte lowest = Convert.ToByte(dicearray[0]);
            Byte lowestindex = 0;
            for (Byte i = 1; i < 5; i++)
            {
                if (lowest > Convert.ToByte(dicearray[i]))
                {
                    lowest = Convert.ToByte(dicearray[i]);
                    lowestindex = i;
                }
            }
            dicearray.RemoveAt(lowestindex);
            Byte low2 = Convert.ToByte(dicearray[0]);
            Byte lowestindex2 = 0;
            for (Byte i = 1; i < 4; i++)
            {
                if (low2 > Convert.ToByte(dicearray[i]))
                {
                    low2 = Convert.ToByte(dicearray[i]);
                    lowestindex2 = i;
                }
            }
            dicearray.RemoveAt(lowestindex2);
            Byte sum = Convert.ToByte(dicearray[0]);
            sum += Convert.ToByte(dicearray[1]);
            sum += Convert.ToByte(dicearray[2]);
            return sum;
        }
    }
}