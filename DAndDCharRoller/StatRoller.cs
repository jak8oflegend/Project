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

        

        public void  statcheck(ComboBox original){


            statarray = new ComboBox[6] {comboBox1,comboBox2,comboBox3,comboBox4,comboBox5,comboBox6};
            for (int i = 0; i < 6; i++)
            {
                if (original.SelectedIndex >= 0 ) {
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
            textBox1.Text = Convert.ToString(statrolldice.DiceRollforstats());
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

        }
    }
}
