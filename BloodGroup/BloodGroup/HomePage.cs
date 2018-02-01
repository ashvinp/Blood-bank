using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BloodGroup
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_BloodGroup ab = new Add_BloodGroup();
            ab.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Donor ab = new Add_Donor();
            ab.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display_Donor_BloodGroup_Wise ab = new Display_Donor_BloodGroup_Wise();
            ab.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display_Donor_Gender_Wise ab = new Display_Donor_Gender_Wise();
            ab.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display_Donor_Age_Weight_Gender_Wise ab = new Display_Donor_Age_Weight_Gender_Wise();
            ab.Show();
            this.Hide();
        }
    }
}
