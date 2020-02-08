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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            qryString = "select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            ds = new DataSet();

        }
    }
}
