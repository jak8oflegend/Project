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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        public static int MAX = 21;

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int first = rand.Next(1, MAX);
            int second = rand.Next(1, MAX);
            int third = rand.Next(1, MAX);
            int fourth = rand.Next(1, MAX);
            int fifth = rand.Next(1, MAX);
            int sixth = rand.Next(1, MAX);
            txt1.Text = first.ToString();
            txt2.Text = second.ToString();
            txt3.Text = third.ToString();
            txt4.Text = fourth.ToString();
            txt5.Text = fifth.ToString();
            txt6.Text = sixth.ToString();
            published

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
