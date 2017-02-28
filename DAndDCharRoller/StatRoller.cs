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
            ///runs errorchecking to prevent crashes
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
                                    string alighnment = cmbo_law.Text + " " + cmbo_alighnment;
                                    string characterclass = Combobox_class.Text;
                                    string template = null; ///comboBox_template/// not yet implemented
                                    string[] statarray2;
                                    statarray2 = new string[6] { comboBox_dicerolls.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text };
                                    int[] valuearray;
                                    valuearray = new int[6] { Convert.ToInt16(txt_stat1.Text), Convert.ToInt16(txt_stat2.Text), Convert.ToInt16(txt_stat3.Text), Convert.ToInt16(txt_stat4.Text), Convert.ToInt16(txt_stat5.Text), Convert.ToInt16(txt_stat6.Text) };
                                    string race = comboBox_race.Text;
                                    createcharacter.go(name, alighnment, characterclass, template,race, statarray2, valuearray);

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