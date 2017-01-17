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
        public StatRoller()
        {
            InitializeComponent();
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
            if (comboBox1.Text == comboBox2.Text) {
                MessageBox.Show("error you have selected " + comboBox1.Text + " in 2 locations this one will be reset");
                comboBox1.SelectedIndex = -1;
            }
            if (comboBox1.Text == comboBox3.Text)
            {
                MessageBox.Show("error you have selected " + comboBox1.Text + " in 2 locations this one will be reset");
                comboBox1.SelectedIndex = -1;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == comboBox1.Text)
            {
                MessageBox.Show("error you have selected " + comboBox2.Text + " in 2 locations this one will be reset");
                comboBox2.SelectedIndex = -1;
            }
            if (comboBox2.Text == comboBox3.Text)
            {
                MessageBox.Show("error you have selected " + comboBox2.Text + " in 2 locations this one will be reset");
                comboBox2.SelectedIndex = -1;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == comboBox1.Text)
            {
                MessageBox.Show("error you have selected " + comboBox3.Text + " in 2 locations this one will be reset");
                comboBox3.SelectedIndex = -1;
            }
            if (comboBox2.Text == comboBox3.Text)
            {
                MessageBox.Show("error you have selected " + comboBox3.Text + " in 2 locations this one will be reset");
                comboBox3.SelectedIndex = -1;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == comboBox1.Text)
            {
                MessageBox.Show("error you have selected " + comboBox4.Text + " in 2 locations this one will be reset");
                comboBox4.SelectedIndex = -1;
            }
            if (comboBox4.Text == comboBox3.Text)
            {
                MessageBox.Show("error you have selected " + comboBox4.Text + " in 2 locations this one will be reset");
                comboBox4.SelectedIndex = -1;
            }
            if (comboBox4.Text == comboBox2.Text)
            {
                MessageBox.Show("error you have selected " + comboBox4.Text + " in 2 locations this one will be reset");
                comboBox4.SelectedIndex = -1;
            }
        }

        private void StatRoller_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == comboBox2.Text)
            {
                MessageBox.Show("error you have selected " + comboBox4.Text + " in 2 locations this one will be reset");
                comboBox4.SelectedIndex = -1;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == comboBox1.Text)
            {
                MessageBox.Show("error you have selected " + comboBox6.Text + " in 2 locations this one will be reset");
                comboBox6.SelectedIndex = -1;
            }
            if (comboBox6.Text == comboBox2.Text)
            {
                MessageBox.Show("error you have selected " + comboBox6.Text + " in 2 locations this one will be reset");
                comboBox6.SelectedIndex = -1;
            }
            if (comboBox6.Text == comboBox3.Text)
            {
                MessageBox.Show("error you have selected " + comboBox6.Text + " in 2 locations this one will be reset");
                comboBox6.SelectedIndex = -1;
            }




        }
    }
}
