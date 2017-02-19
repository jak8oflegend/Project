using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    /// <summary>
    /// handles character creation
    /// todo: add template handling
    /// </summary>
    class createcharacter
    {

        public static void go(string name, string alighnment, string characterclass, string template, string race, string[] statarray2, int[] valuearray)
        {
            ///sets stats and then passes on to check race
            int strength=-1;
            int dexterity=-1;
            int constitution=-1;
            int intelligence=-1;
            int wisdom=-1;
            int charisma=-1;
            for (int i = 0; i < 7; i++)
            {
                if (statarray2[i] == "charisma")
                {
                    charisma = valuearray[i];
                }
                if (statarray2[i] == "strength")
                {
                    strength = valuearray[i];
                }
                if (statarray2[i] == "dexterity")
                {
                    dexterity = valuearray[i];
                }
                if (statarray2[i] == "constitution")
                {
                    constitution = valuearray[i];
                }
                if (statarray2[i] == "intelligence")
                {
                    intelligence = valuearray[i];
                }
                if (statarray2[i] == "wisdom")
                {
                    wisdom = valuearray[i];
                }

            }
            racemethod(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma);
        }
        public static void racemethod(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            ///handle racial adjustments
            ///pass to template for template adjustments
            templatemethod(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma);
        }
        public static void templatemethod(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            ///handle template adjustments not yet done
            ///pass to charclass for final adjustments
           classmethod(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma);
        }
        public static void classmethod(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            ///handle class adjustments calculate hp and skill points on per class basis 
            ///pass to form 3 for skill asighnment
            int strengthbonus = (strength - 10) / 2;
            int dexteritybonus = (dexterity - 10) / 2;
            int constitutionbonus = (constitution - 10) / 2;
            int intelligencebonus = (intelligence - 10) / 2;
            int wisdombonus = (wisdom - 10) / 2;
            int charismabonus = (charisma - 10) / 2;

        }
    }
}
