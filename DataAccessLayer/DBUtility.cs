using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DBUtility
    {
        public static int ModifyData(string query, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='G:\Car Mechanic Project\MCM\MobileCarMechanics\App_Data\MCMdb.mdf';Integrated Security=True;User Instance=True";
            //connection.ConnectionString = @"Data Source=SQL5005.Smarterasp.net;Initial Catalog=DB_9FEC09_MCMdb;User Id=DB_9FEC09_MCMdb_admin;Password=mcm12345;"; 
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddRange(parameters.ToArray());
            command.Connection = connection;

            connection.Open();
            int x = command.ExecuteNonQuery();
            connection.Close();

            return x;
        }

        public static DataTable SelectData(string query, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='G:\Car Mechanic Project\MCM\MobileCarMechanics\App_Data\MCMdb.mdf';Integrated Security=True;User Instance=True";
            
            //connection.ConnectionString = @"Data Source=SQL5005.Smarterasp.net;Initial Catalog=DB_9FEC09_MCMdb;User Id=DB_9FEC09_MCMdb_admin;Password=mcm12345;";
;
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddRange(parameters.ToArray());
            command.Connection = connection;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}