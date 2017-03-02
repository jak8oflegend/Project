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
    public partial class StatRoller : Form
    {
        ComboBox[] statarray;

        public StatRoller()
        {

            InitializeComponent();

        }



        public void statcheck(ComboBox original)
        {

            /// checks to make sure no stat is duplicated so no stat is left null
            statarray = new ComboBox[6] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };
            for (int i = 0; i < 6; i++)
            {
                if (original.SelectedIndex >= 0)
                {
                    if (original != statarray[i])
                    {
                        if (original.SelectedIndex == statarray[i].SelectedIndex)
                        {
                            MessageBox.Show("error you have selected " + original.Text + " in 2 locations this one will be reset");
                            original.SelectedIndex = -1;


                        }
                    }
                }
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            statcheck(comboBox1);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcheck(comboBox2);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcheck(comboBox4);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcheck(comboBox3);
        }

        private void StatRoller_Load(object sender, EventArgs e)
        {
            ///loads a stat roll when form loads
            DiceRoll();
        }

        private void DiceRoll()
        {
            txt_stat1.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_stat2.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_stat3.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_stat4.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_stat5.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_stat6.Text = Convert.ToString(statrolldice.DiceRollforstats());
        }

        private void ReRoll()
        {
            if (comboBox_dicerolls.SelectedIndex == 0)
            {
                txt_stat1.Text = Convert.ToString(statrolldice.DiceRollforstats());
                txt_stat2.Text = Convert.ToString(statrolldice.DiceRollforstats());
                txt_stat3.Text = Convert.ToString(statrolldice.DiceRollforstats());
                txt_stat4.Text = Convert.ToString(statrolldice.DiceRollforstats());
                txt_stat5.Text = Convert.ToString(statrolldice.DiceRollforstats());
                txt_stat6.Text = Convert.ToString(statrolldice.DiceRollforstats());
            }
            if (comboBox_dicerolls.SelectedIndex == 1)
            {
                txt_stat1.Text = Convert.ToString(statrolldice.DiceRollforstats3d6());
                txt_stat2.Text = Convert.ToString(statrolldice.DiceRollforstats3d6());
                txt_stat3.Text = Convert.ToString(statrolldice.DiceRollforstats3d6());
                txt_stat4.Text = Convert.ToString(statrolldice.DiceRollforstats3d6());
                txt_stat5.Text = Convert.ToString(statrolldice.DiceRollforstats3d6());
                txt_stat6.Text = Convert.ToString(statrolldice.DiceRollforstats3d6());
            }
            if (comboBox_dicerolls.SelectedIndex == 2)
            {
                txt_stat1.Text = Convert.ToString(statrolldice.DiceRollforstats5d6());
                txt_stat2.Text = Convert.ToString(statrolldice.DiceRollforstats5d6());
                txt_stat3.Text = Convert.ToString(statrolldice.DiceRollforstats5d6());
                txt_stat4.Text = Convert.ToString(statrolldice.DiceRollforstats5d6());
                txt_stat5.Text = Convert.ToString(statrolldice.DiceRollforstats5d6());
                txt_stat6.Text = Convert.ToString(statrolldice.DiceRollforstats5d6());
            }
            if (comboBox_dicerolls.SelectedIndex == 3)
            {
                txt_stat1.Text = 15.ToString();
                txt_stat2.Text = 14.ToString();
                txt_stat3.Text = 13.ToString();
                txt_stat4.Text = 12.ToString();
                txt_stat5.Text = 10.ToString();
                txt_stat6.Text = 8.ToString();
            }
            if (comboBox_dicerolls.SelectedIndex == 4)
            {
                txt_stat1.Text = 13.ToString();
                txt_stat2.Text = 12.ToString();
                txt_stat3.Text = 11.ToString();
                txt_stat4.Text = 10.ToString();
                txt_stat5.Text = 9.ToString();
                txt_stat6.Text = 8.ToString();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcheck(comboBox5);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcheck(comboBox6);

        }

        private void btn_reroll_Click(object sender, EventArgs e)
        {
            ReRoll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            skillsdefinition[] skillList;
            skillsdefinition appraise = new skillsdefinition("Appraise", 0);
            skillsdefinition balance = new skillsdefinition("Balance", 0);
            skillsdefinition bluff = new skillsdefinition("Bluff", 0);
            skillsdefinition climb = new skillsdefinition("Climb", 0);
            skillsdefinition concentrate = new skillsdefinition("Concentrate", 0);
            skillsdefinition craft1 = new skillsdefinition("Craft 1", 0);
            skillsdefinition craft2 = new skillsdefinition("Craft 2", 0);
            skillsdefinition craft3 = new skillsdefinition("craft 3", 0);
            skillsdefinition deciferScript = new skillsdefinition("Decifer Script", 0);
            skillsdefinition diplomacy = new skillsdefinition("Diplomacy", 0);
            skillsdefinition disableDevice = new skillsdefinition("Disable Device", 0);
            skillsdefinition disguise = new skillsdefinition("Disguise", 0);
            skillsdefinition escapeArtist = new skillsdefinition("Escape Artist", 0);
            skillsdefinition forgery = new skillsdefinition("Forgery", 0);
            skillsdefinition gatherInformation = new skillsdefinition("Gather Information", 0);
            skillsdefinition handleanimal = new skillsdefinition("Handle Animal", 0);
            skillsdefinition heal = new skillsdefinition("Heal", 0);
            skillsdefinition intimidate = new skillsdefinition("Intimidate", 0);
            skillsdefinition jump = new skillsdefinition("jump", 0);
            skillsdefinition arcana = new skillsdefinition("Knowledge(Arcana)", 0);
            skillsdefinition Architecture = new skillsdefinition("Knowledge(architecture)", 0);
            skillsdefinition dungeonereing = new skillsdefinition("Knowledge(Dungeoneering)", 0);
            skillsdefinition geography = new skillsdefinition("Knowledge(Geography)", 0);
            skillsdefinition history = new skillsdefinition("Knowledge(history)", 0);
            skillsdefinition local = new skillsdefinition("Knowledge(local)", 0);
            skillsdefinition nature = new skillsdefinition("Knowledge(nature)", 0);
            skillsdefinition noble = new skillsdefinition("Knowledge(noble)", 0);
            skillsdefinition religion = new skillsdefinition("Knowledge(religion)", 0);
            skillsdefinition planes = new skillsdefinition("Knowledge(planes)", 0);
            skillsdefinition listen = new skillsdefinition("listen", 0);
            skillsdefinition moveSilently = new skillsdefinition("Move Silently", 0);
            skillsdefinition openLock = new skillsdefinition("Open lock", 0);
            skillsdefinition preform1 = new skillsdefinition("Preform 1", 0);
            skillsdefinition preform2 = new skillsdefinition("Preform 2", 0);
            skillsdefinition preform3 = new skillsdefinition("Preform 3", 0);
            skillsdefinition preform4 = new skillsdefinition("Preform 4", 0);
            skillsdefinition preform5 = new skillsdefinition("preform 5", 0);
            skillsdefinition profession = new skillsdefinition("Profession", 0);
            skillsdefinition ride = new skillsdefinition("Ride", 0);
            skillsdefinition search = new skillsdefinition("Search", 0);
            skillsdefinition senseMotive = new skillsdefinition("Sense Motive", 0);
            skillsdefinition sleightOfHand = new skillsdefinition("Sleight of Hand", 0);
            skillsdefinition speakLanguage = new skillsdefinition("Speak Language ", 0);
            skillsdefinition spellcraft = new skillsdefinition("Spell Craft", 0);
            skillsdefinition spot = new skillsdefinition("Spot", 0);
            skillsdefinition survival = new skillsdefinition("Survival", 0);
            skillsdefinition swim = new skillsdefinition("Swim", 0);
            skillsdefinition tumble = new skillsdefinition("Tumble", 0);
            skillsdefinition useMagicDevice = new skillsdefinition("Use Magic Device", 0);
            skillsdefinition useRope= new skillsdefinition("Use Rope", 0);
            skillsdefinition autohypnosis = new skillsdefinition("Auto Hypnosis", 0);
            skillsdefinition psionics = new skillsdefinition("Psionics", 0);
            skillsdefinition psicraft = new skillsdefinition("Psi craft", 0);
            skillsdefinition usePsi = new skillsdefinition("Use Psi", 0);
            skillList = new skillsdefinition[54] {
              appraise ,
              balance ,
              bluff ,
              climb ,
              concentrate ,
              craft1 ,
              craft2 ,
              craft3 ,
              deciferScript ,
              diplomacy ,
              disableDevice ,
              disguise ,
              escapeArtist ,
              forgery ,
              gatherInformation ,
              handleanimal ,
              heal ,
              intimidate ,
              jump ,
              arcana ,
              Architecture ,
              dungeonereing ,
              geography ,
              history ,
              local ,
              nature ,
              noble ,
              religion ,
              planes ,
              listen ,
              moveSilently ,
              openLock ,
              preform1 ,
              preform2 ,
              preform3 ,
              preform4 ,
              preform5 ,
              profession ,
              ride ,
              search ,
              senseMotive ,
              sleightOfHand ,
              speakLanguage ,
              spellcraft ,
              spot ,
              survival ,
              swim ,
              tumble ,
              useMagicDevice ,
              useRope,
              autohypnosis ,
              psionics ,
              psicraft ,
              usePsi  };

            ///runs errorchecking to prevent crashes
            ///to do clean this up
            statarray = new ComboBox[6] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };
            for (int i = 0; i < 6; i++)
            {
                if (statarray[i].SelectedIndex < 0)
                {

                    MessageBox.Show("error you have not  set one of your stats");

                }
                else
                {
                    if (Combobox_class.SelectedIndex < 0)
                    {
                        MessageBox.Show("error you have not selected a class");
                    }
                    else {
                        if (comboBox_race.SelectedIndex < 0)
                        {
                            MessageBox.Show("error you have not selected a race");
                        }
                        else
                        {
                            if (cmbo_alighnment.SelectedIndex < 0)
                            {
                                MessageBox.Show("error you have not selected an alighnment(good/evil/netural)");
                            }
                            else
                            {

                                if (cmbo_law.SelectedIndex < 0)
                                {
                                    MessageBox.Show("error you have not selected an alighnment(lawful/chaotic/netural)");
                                }
                                else
                                {
                                    ///get name
                                    string name = txt_name.Text;
                                    ///get alighnment
                                    string alighnment = cmbo_law.Text + " " + cmbo_alighnment.Text;
                                    string characterclass = Combobox_class.Text;
                                    string template = null; ///comboBox_template/// not yet implemented
                                    string[] statarray2;
                                    statarray2 = new string[6] { comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text };
                                    int[] valuearray;
                                    valuearray = new int[6] { Convert.ToInt16(txt_stat1.Text), Convert.ToInt16(txt_stat2.Text), Convert.ToInt16(txt_stat3.Text), Convert.ToInt16(txt_stat4.Text), Convert.ToInt16(txt_stat5.Text), Convert.ToInt16(txt_stat6.Text) };
                                    string race = comboBox_race.Text;
                                    createcharacter.go(name, alighnment, characterclass, template,race, statarray2, valuearray, skillList);

                                }

                            }
                            

                        }
                    }
                }

            }
        }

        private void comboBox_dicerolls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}