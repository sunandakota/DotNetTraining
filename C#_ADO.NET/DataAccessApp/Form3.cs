﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qryString = "Update Products Set Unitprice = " + Convert.ToDouble(txtPrice.Text) + "where ProductName = '" + cmbProducts.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated", "New Product Price:");

            sqlCon.Close();
        }

        private void cmbProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from Products where ProductName = '" + cmbProducts.Text + "'";

            sqlCmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();
            lblPrice.Text = "Price: " + sqlCmd.ExecuteScalar().ToString();

            sqlCon.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10130\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=true;";

            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
            qryString = "select ProductName from Products";

            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                cmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            cmbProducts.Text = "All products";
        }

        
    }
}
