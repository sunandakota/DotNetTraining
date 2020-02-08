using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerAppProg
{
    class Program
    {
       static SqlConnection sqlCon;
        static SqlCommand sqlCmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
       static string conString, qryString;
        static DataSet ds;

        static void Main(string[] args)
        {
            
            conString = "data source=BLT10130\\SQLEXPRESS2014;Initial Catalog=NorthWind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            da = new SqlDataAdapter();
            while (dr.Read())
            {
                Console.WriteLine("ProductName:{0}", dr["ProductName"]);

            }
            dr.Close();
            sqlCon.Close();
            LINQToDataSets();
        }

        public static void LINQToDataSets()
        {
            qryString = "select customerID,CompanyName,ContactName,Address,Country from Customers";
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand(qryString,sqlCon);

                da = new SqlDataAdapter(sqlCmd);

                ds = new DataSet();
                da.Fill(ds, "CustomersInfo");

                DataTable dtCustomers = ds.Tables["CustomersInfo"];

                var specificCustomers = from customer in dtCustomers.AsEnumerable()
                                        where customer.Field<string>("Country") == "UK"
                                        select new
                                        {
                                            custID = customer["CustomerID"],
                                            companyName = customer["CompanyName"],
                                            contactName = customer["ContactName"],
                                            address = customer["Address"],
                                            country = customer["Country"]
                                        };
                foreach (var customer in specificCustomers)
                {
                    Console.WriteLine("\n\nCustomerID: {0}", customer.custID);
                    Console.WriteLine("Name: {0}", customer.contactName);
                    Console.WriteLine("CompanyName: {0}", customer.companyName);
                    Console.WriteLine("Address: {0}", customer.address);
                    Console.WriteLine("Country {0}", customer.country);
                }

            }
        }
    }
}
