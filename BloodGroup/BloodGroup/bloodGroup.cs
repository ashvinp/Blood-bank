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
    class bloodGroup
    {
        SqlConnection conn;
        SqlCommand cmd, cmd2;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public void connectionOpen()
        {
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"G:\\System\\Software and others(F)\\Notes\\MCA 5th Sem\\Practicals\\13MCA57-DotNet Lab\\BloodGroup\\BloodGroup\\BloodGroup\\BloodGroup.mdf\";Integrated Security=True;User Instance=True");
            conn.Open();
        }

        public void connectionClose()
        {
            conn.Close();
        }

        public void addbloodgroup(String name)
        {
            cmd = new SqlCommand("insert into tbl_BloodGroup values('" + name + "') ", conn);
            cmd.ExecuteNonQuery();
        }

        public void adddonor(String donorname, String address, long contactno, String dob, String gender, int weight, int bloodid)
        {
            cmd2 = new SqlCommand("insert into tbl_Donor values('" + donorname + "','" + address + "'," + contactno + ",'" + dob + "','" + gender + "'," + weight + ", " + bloodid + ") ", conn);
            cmd2.ExecuteNonQuery();
        }

        public SqlDataReader displayComboBox(String TableName)
        {
            cmd = new SqlCommand("select * from " + TableName, conn);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet displaybloodvise(int selectedbloodid)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbl_Donor where bloodid=" + selectedbloodid, conn);
            da.Fill(ds, "tbl_Donor");
            return ds;
        }
        public DataSet diplaygendervise(string gender)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbl_Donor where gender='" + gender + "'", conn);
            da.Fill(ds, "tbl_Donor");
            return ds;
        }
        public DataSet diplayawgvise(string gender)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbl_Donor where weight>45 and gender='" + gender + "'", conn);
            da.Fill(ds, "tbl_Donor");
            return ds;
        }
    }
}
