using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAndDCharRoller
{
    /// <summary>
    /// creates skills form than stores complete character in the db
    /// </summary>
    public partial class skills : Form
    {
        string nameform;
        string alighnmentform;
        string characterclassform;
        string templateform;
        string raceform;
        int strengthform;
        int dexterityform;
        int constitutionform;
        int intelligenceform;
        int wisdomform;
        int charismaform;
        skillsdefinition[] skillzform;
        int strengthbonusform;
            int dexteritybonusform;
            int constitutionbonusform;
            int intelligencebonusform;
            int wisdombonusform;
            int charismabonusform;
        int skillpointsform;
        public skills(string name, string alighnment, string characterclass, string template, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, skillsdefinition[] skills,int strengthbonus,
            int dexteritybonus,
            int constitutionbonus,
            int intelligencebonus,
            int wisdombonus,
            int charismabonus,
            int skillpoints)

        {
                     nameform = name;
         alighnmentform = alighnment ;
         characterclassform = characterclass;
         templateform = template;
         raceform = race;
         strengthform = strength;
         dexterityform = dexterity;
         constitutionform = constitution;
         intelligenceform = intelligence;
         wisdomform = wisdom;
         charismaform = charisma;
         skillzform= skills;
         strengthbonusform = strengthbonus;
             dexteritybonusform= dexteritybonus;
             constitutionbonusform =constitutionbonus;
             intelligencebonusform= intelligencebonus;
             wisdombonusform =wisdombonus;
             charismabonusform = charismabonus;
         skillpointsform= skillpoints;
            InitializeComponent();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void skills_Load(object sender, EventArgs e)
        {
            txt_total.Text = ("0 / " + Convert.ToString(skillpointsform));
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {
            ComboBox[] usedsp;
            usedsp = new ComboBox[55] { comboBox1,comboBox2,comboBox3,comboBox4,comboBox5,comboBox6,comboBox7,comboBox8,comboBox9,comboBox10,
                comboBox11,comboBox12,comboBox13,comboBox14,comboBox15,comboBox16,comboBox17,comboBox18,comboBox19,comboBox20,comboBox21,comboBox22,
                comboBox23,comboBox24,comboBox25,comboBox26,comboBox27,comboBox28,comboBox29,comboBox30,comboBox31,comboBox32,comboBox33,comboBox34,
                comboBox35,comboBox36,comboBox37,comboBox38,comboBox39,comboBox40,comboBox46,comboBox47,comboBox48,comboBox49,comboBox50,comboBox51,
                comboBox52,comboBox53,comboBox54,comboBox55,comboBox56,comboBox57,comboBox58,comboBox59,comboBox60, };
            int sum = 0;
            for (int i = 0; i < 55; i++)
            {
                if (usedsp[i].Text != "") { sum += Convert.ToInt16(usedsp[i].Text); }
            }
            txt_total.Text = (Convert.ToString(sum)+ " / " + Convert.ToString(skillpointsform));
            if (sum > skillpointsform)
            {
                btn_storetodb.Enabled = false;
                btn_storetodb.Text = "You have to many skill points";
            }
            else if (sum < skillpointsform) {
                btn_storetodb.Enabled = false;
                btn_storetodb.Text = "You have to not spent all your skill points";
            }
            else {
                btn_storetodb.Enabled = true;
                btn_storetodb.Text = "store character to database";
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox31_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void btn_storetodb_Click(object sender, EventArgs e)
        {
            ComboBox[] usedsp;
            usedsp = new ComboBox[55] { comboBox1,comboBox2,comboBox3,comboBox4,comboBox5,comboBox6,comboBox7,comboBox8,comboBox9,comboBox10,
                comboBox11,comboBox12,comboBox13,comboBox14,comboBox15,comboBox16,comboBox17,comboBox18,comboBox19,comboBox20,comboBox21,comboBox22,
                comboBox23,comboBox24,comboBox25,comboBox26,comboBox27,comboBox28,comboBox29,comboBox30,comboBox31,comboBox32,comboBox33,comboBox34,
                comboBox35,comboBox36,comboBox37,comboBox38,comboBox39,comboBox40,comboBox46,comboBox47,comboBox48,comboBox49,comboBox50,comboBox51,
                comboBox52,comboBox53,comboBox54,comboBox55,comboBox56,comboBox57,comboBox58,comboBox59,comboBox60, };
            for (int i = 0; i < 55; i++) {
                if (usedsp[i].Text != "") { skillzform[i].value += Convert.ToInt16(usedsp[i].Text); }
            }
            character toBeCreated = new character(
                nameform, 
                alighnmentform, 
                characterclassform, 
                //templateform, not implemented
                raceform, 
                strengthform, 
                dexterityform, 
                constitutionform, 
                intelligenceform, 
                wisdomform, 
                charismaform,  
                strengthbonusform,
              dexteritybonusform,
              constitutionbonusform,
               intelligencebonusform,
              wisdombonusform,
              charismabonusform,
              skillzform);
            characterdb.Addcharacter(toBeCreated);
        }
    }
}