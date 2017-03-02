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
    public class createcharacter
    {

        public static void go(string name, string alighnment, string characterclass, string template, string race, string[] statarray2, int[] valuearray, skillsdefinition[] skills)
        {
            ///sets stats and then passes on to check race
            int strength=-1;
            int dexterity=-1;
            int constitution=-1;
            int intelligence=-1;
            int wisdom=-1;
            int charisma=-1;
            for (int i = 0; i < 6; i++)
            {
                if (statarray2[i] == "Charisma")
                {
                    charisma = valuearray[i];
                }
                if (statarray2[i] == "Strength")
                {
                    strength = valuearray[i];
                }
                if (statarray2[i] == "Dexterity")
                {
                    dexterity = valuearray[i];
                }
                if (statarray2[i] == "Constitution")
                {
                    constitution = valuearray[i];
                }
                if (statarray2[i] == "Intelligence")
                {
                    intelligence = valuearray[i];
                }
                if (statarray2[i] == "Wisdom")
                {
                    wisdom = valuearray[i];
                }

            }
            racemethod(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma,skills);
        }
        public static void racemethod(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, skillsdefinition[] skills)
        {
            ///handle racial adjustments
            ///pass to template for template adjustments
            templatemethod(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma,skills);
        }
        public static void templatemethod(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, skillsdefinition[] skills)
        {
            ///handle template adjustments not yet done
            ///pass to charclass for final adjustments
           classmethod(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma,skills);
        }
        public static void classmethod(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, skillsdefinition[] skills)
        {
            ///handle class adjustments calculate hp and skill points on per class basis 
            ///pass to form 3 for skill asighnment
            int strengthbonus = (strength - 10) / 2;
            int dexteritybonus = (dexterity - 10) / 2;
            int constitutionbonus = (constitution - 10) / 2;
            int intelligencebonus = (intelligence - 10) / 2;
            int wisdombonus = (wisdom - 10) / 2;
            int charismabonus = (charisma - 10) / 2;
            calculateskills(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma, skills, strengthbonus,
              dexteritybonus,
              constitutionbonus,
               intelligencebonus,
              wisdombonus,
              charismabonus);
        }
        public static void calculateskills(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, skillsdefinition[] skills,int strengthbonus,
            int dexteritybonus,
            int constitutionbonus,
            int intelligencebonus,
            int wisdombonus,
            int charismabonus )
        {
            int skillpoints;
            if (characterclass == "Paladin") {  skillpoints = ((2 + intelligencebonus) * 4); }
            else {
                /// handle skill points for other classes 
                 skillpoints = 100;
                if (skillpoints < 4) { skillpoints = (4); }
            }
            skills frm = new skills(name, alighnment, characterclass, template, race, strength, dexterity, constitution, intelligence, wisdom, charisma, skills, strengthbonus,
              dexteritybonus,
              constitutionbonus,
               intelligencebonus,
              wisdombonus,
              charismabonus,
              skillpoints);
            frm.ShowDialog();
            


        }
    }
}
