using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    /// <summary>
    /// defines character for adding to db
    /// todo: add alighnment
    /// todo: add template once it is implemented
    /// todo: add in the skills once form3 is implemented and skills are implemented
    /// </summary>
    public class character
    {
        public character() { }
        public character(string name,
            string race,
            string jobclass,
            int Strength,
int Dexterity,
int Constitution,
int Intelligence,
int Wisdom,
int Charisma,
            int Strengthbonus,
int Dexteritybonus,
int Constitutionbonus,
int Intelligencebonus,
int Wisdombonus,
int Charismabonus
)
        {
            this.name = name;
            this.race = race;
            this.jobclass = jobclass;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intelligence = Intelligence;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
            this.Strengthbonus = Strengthbonus;
            this.Dexteritybonus = Dexteritybonus;
            this.Constitutionbonus = Constitutionbonus;
            this.Intelligencebonus = Intelligencebonus;
            this.Wisdombonus = Wisdombonus;
            this.Charismabonus = Charismabonus;

        }
        public string name { get; set; }
        public string race { get; set; }
        public string jobclass { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Strengthbonus { get; set; }
        public int Dexteritybonus { get; set; }
        public int Constitutionbonus { get; set; }
        public int Intelligencebonus { get; set; }
        public int Wisdombonus { get; set; }
        public int Charismabonus { get; set; }
    }
}
