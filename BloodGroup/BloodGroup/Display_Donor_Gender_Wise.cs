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
    public partial class Display_Donor_Gender_Wise : Form
    {
        bloodGroup ob = new bloodGroup();
        SqlDataReader dr;
        DataSet ds = new DataSet();

        public Display_Donor_Gender_Wise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.connectionOpen();
            ds = ob.diplaygendervise(comboBox1.SelectedItem.ToString());

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_Donor";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage fa = new HomePage();
            fa.Show();
            this.Hide();
        }

        private void Display_Donor_Gender_Wise_Load(object sender, EventArgs e)
        {
            ob.connectionOpen();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            ob.connectionClose();
        }
    }
}
