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
    public partial class Add_BloodGroup : Form
    {
        public Add_BloodGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage fa = new HomePage();
            bloodGroup ob = new bloodGroup();
            ob.connectionOpen();
            ob.addbloodgroup(textBox1.Text.ToString());
            ob.connectionClose();
            MessageBox.Show("Data Added Successfully");
            fa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage fa = new HomePage();
            fa.Show();
            this.Hide();
        }

        private void Add_BloodGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
