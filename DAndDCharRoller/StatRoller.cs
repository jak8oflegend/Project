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


            statarray = new ComboBox[6] { c, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };
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

            statcheck(c);
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
            txt_1.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_2.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_3.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_4.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_5.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_6.Text = Convert.ToString(statrolldice.DiceRollforstats());
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
            txt_1.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_2.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_3.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_4.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_5.Text = Convert.ToString(statrolldice.DiceRollforstats());
            txt_6.Text = Convert.ToString(statrolldice.DiceRollforstats());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            statarray = new ComboBox[6] { c, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };
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
                        MessageBox.Show("error you have not  selected a class");
                    }
                    else {
                        if (comboBox_race.SelectedIndex < 0)
                        {
                            MessageBox.Show("error you have not  selected a race");
                        }
                        else
                        {
                            ///implement stats
                            
                        }
                    }
                }

            }
        }
    }
}