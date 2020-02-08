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

namespace DataAccessWithDataAdaptar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;

        private void btnProducts_Click(object sender, EventArgs e)
        {
            qryString = "select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "ProductsInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "ProductsInfo";
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            qryString = "select * from categories";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "CategoriesInfo");           
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "CategoriesInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10130\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=true;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();

        }
    }
}
