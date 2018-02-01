using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodGroup
{
    public partial class Add_Donor : Form
    {
        bloodGroup ob = new bloodGroup();
        SqlDataReader dr;
        HomePage fa = new HomePage();

        public Add_Donor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.connectionOpen();
            ob.adddonor(textBox1.Text.ToString(), textBox2.Text.ToString(), long.Parse(textBox3.Text.ToString()), dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox1.SelectedItem.ToString(), int.Parse(textBox4.Text.ToString()), int.Parse((comboBox2.SelectedIndex) + 1.ToString()));
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

        private void Add_Donor_Load(object sender, EventArgs e)
        {
            ob.connectionOpen();
            dr = ob.displayComboBox("tbl_BloodGroup");
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["bloodgroup"]);
            }
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            ob.connectionClose();
        }
    }
}
