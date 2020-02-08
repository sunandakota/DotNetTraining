using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DataAccessApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select ContactName from Customers where Country= '" + cmbCountry.Text + "'";

            sqlCmd = new SqlCommand(qryString, sqlCon);

            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            { 
                lstContacts.Items.Add(dr["ContactName"]);
            }
                dr.Close();
           
            sqlCon.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblContactName_Click(object sender, EventArgs e)
        {


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10130\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=true;";

            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
            qryString = "select distinct Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                cmbCountry.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();

            cmbCountry.Text = "All Country";

        }
    }
}
