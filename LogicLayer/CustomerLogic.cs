using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class CustomerLogic
    {
        public static int Insert(Customer obj)
        {
            string query = "Insert Customer VALUES (@CustomerName, @CustomerEmail, @AreaID, @CustomerMobileNo, @CustomerAddress, @CustomerUsername, @CustomerPassword, @CustomerPhoto)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerName", obj.CustomerName));
            par.Add(new SqlParameter("@CustomerEmail", obj.CustomerEmail));
            par.Add(new SqlParameter("@AreaID", obj.AreaID));
            par.Add(new SqlParameter("@CustomerMobileNo", obj.CustomerMoblieNo));
            par.Add(new SqlParameter("@CustomerAddress", obj.CustomerAddress));
            par.Add(new SqlParameter("@CustomerUsername", obj.CustomerUsername));
            par.Add(new SqlParameter("@CustomerPassword", obj.CustomerPassword));
            par.Add(new SqlParameter("@CustomerPhoto", obj.CustomerPhoto));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(Customer obj)
        {
            string query = @"UPDATE Customer SET CustomerName= @CustomerName, CustomerEmail = @CustomerEmail, AreaID = @AreaID, CustomerMobileNo = @CustomerMobileNo, CustomerAddress = @CustomerAddress, CustomerUsername = @CustomerUsername, CustomerPassword = @CustomerPassword, CustomerPhoto = @CustomerPhoto
                            WHERE CustomerID = @CustomerID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerName", obj.CustomerName));
            par.Add(new SqlParameter("@CustomerEmail", obj.CustomerEmail));
            par.Add(new SqlParameter("@AreaID", obj.AreaID));
            par.Add(new SqlParameter("@CustomerMobileNo", obj.CustomerMoblieNo));
            par.Add(new SqlParameter("@CustomerAddress", obj.CustomerAddress));
            par.Add(new SqlParameter("@CustomerUsername", obj.CustomerUsername));
            par.Add(new SqlParameter("@CustomerPassword", obj.CustomerPassword));
            par.Add(new SqlParameter("@CustomerPhoto", obj.CustomerPhoto));
            par.Add(new SqlParameter("@CustomerID", obj.CustomerID));
            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE Customer WHERE CustomerID = @CustomerID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static Customer SelectByID(int ID)
        {
            string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            Customer obj = new Customer();
            if (dt.Rows.Count == 1)
            {
                obj.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                obj.CustomerEmail = dt.Rows[0]["CustomerEmail"].ToString();
                obj.AreaID = Convert.ToInt32(dt.Rows[0]["AreaID"]);
                obj.CustomerMoblieNo = dt.Rows[0]["CustomerMobileNo"].ToString();
                obj.CustomerAddress = dt.Rows[0]["CustomerAddress"].ToString();
                obj.CustomerUsername = dt.Rows[0]["CustomerUsername"].ToString();
                obj.CustomerPassword = dt.Rows[0]["CustomerPassword"].ToString();
                obj.CustomerPhoto = dt.Rows[0]["CustomerPhoto"].ToString();
            }
            return obj;
        }

        public static Customer Validate(string CustomerUsername, string CustomerPassword)
        {

            string query = @"SELECT * FROM Customer WHERE CustomerUsername = @CustomerUsername AND CustomerPassword = @CustomerPassword";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerUsername", CustomerUsername));
            par.Add(new SqlParameter("@CustomerPassword", CustomerPassword));
            DataTable dt = DBUtility.SelectData(query, par);
            if (dt.Rows.Count == 1)
            {
                Customer C = new Customer();
                C.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                C.CustomerName = dt.Rows[0]["CustomerName"].ToString();
                C.CustomerEmail = dt.Rows[0]["CustomerEmail"].ToString();
                C.AreaID = Convert.ToInt32(dt.Rows[0]["AreaID"]);
                C.CustomerMoblieNo = dt.Rows[0]["CustomerMobileNo"].ToString();
                C.CustomerAddress = dt.Rows[0]["CustomerAddress"].ToString();
                C.CustomerUsername = dt.Rows[0]["CustomerUsername"].ToString();
                C.CustomerPassword = dt.Rows[0]["CustomerPassword"].ToString();
                C.CustomerPhoto = dt.Rows[0]["CustomerPhoto"].ToString();
                return C;
            }
            else
            {
                return new Customer();
            }
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM Customer";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }
        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM Area INNER JOIN Customer ON Area.AreaID = Customer.AreaID WHERE CustomerName LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

        public static bool checkAvailable(string username)
        {
            string query = @"SELECT * FROM Customer WHERE CustomerUsername = @CustomerUsername";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerUsername", username));
            DataTable dt = DBUtility.SelectData(query, par);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Customer SelectByUsername(string username)
        {
            string query = @"SELECT * FROM Customer WHERE CustomerUsername = @CustomerUsername";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerUsername", username));
            DataTable dt = DBUtility.SelectData(query, par);
            if (dt.Rows.Count == 1)
            {
                return SelectByID(Convert.ToInt32(dt.Rows[0]["CustomerID"]));
            }
            else return new Customer();
            
        }
    }
}
