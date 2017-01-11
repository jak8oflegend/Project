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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            /// not yet implemented
            MessageBox.Show("Not yet implemented");
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            ///opens statroller form
            StatRoller statroller = new StatRoller();
            statroller.Visible = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
