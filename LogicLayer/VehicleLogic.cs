using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;


namespace LogicLayer
{
    public class VehicleLogic
    {

        public static int Insert(Vehicle obj)
        {
            string query = "Insert Vehicle VALUES (@VehicleNumber, @Make, @Model, @CustomerID, @VehiclePhoto)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@VehicleNumber", obj.VehicleNumber));            
            par.Add(new SqlParameter("@Make", obj.Make));
            par.Add(new SqlParameter("@Model", obj.Model));
            par.Add(new SqlParameter("@CustomerID", obj.CustomerID));
            par.Add(new SqlParameter("@VehiclePhoto", obj.VehiclePhoto));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(Vehicle obj)
        {
            string query = @"UPDATE Vehicle SET VehicleNumber = @VehicleNumber, Make = @Make, Model = @Model, CustomerID = @CustomerID, VehiclePhoto = @VehiclePhoto
                            WHERE VehicleID = @VehicleID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@VehicleNumber", obj.VehicleNumber));            
            par.Add(new SqlParameter("@Make", obj.Make));
            par.Add(new SqlParameter("@Model", obj.Model));
            par.Add(new SqlParameter("@CustomerID", obj.CustomerID));
            par.Add(new SqlParameter("@VehiclePhoto", obj.VehiclePhoto));
            par.Add(new SqlParameter("@VehicleID", obj.VehicleID));
            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE Vehicle WHERE VehicleID = @VehicleID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@VehicleID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static DataTable SelectByCustomerID(int ID)
        {
            string query = "SELECT * FROM Vehicle WHERE CustomerID = @CustomerID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerID", ID));
            return DBUtility.SelectData(query, par);

            
        }

        public static Vehicle SelectByID(int ID)
        {
            string query = "SELECT * FROM Vehicle WHERE VehicleID = @VehicleID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@VehicleID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            Vehicle obj = new Vehicle();
            if (dt.Rows.Count == 1)
            {
                obj.VehicleID = Convert.ToInt32(dt.Rows[0]["VehicleID"]);
                obj.VehicleNumber = dt.Rows[0]["VehicleNumber"].ToString();
                obj.Make = dt.Rows[0]["Make"].ToString();
                obj.Model = dt.Rows[0]["Model"].ToString();
                obj.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                obj.VehiclePhoto = dt.Rows[0]["VehiclePhoto"].ToString();
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM Vehicle";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM Vehicle INNER JOIN Customer ON Customer.CustomerID = Vehicle.CustomerID WHERE VehicleNumber LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }
    }
}
