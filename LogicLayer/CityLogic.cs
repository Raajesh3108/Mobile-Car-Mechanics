using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class CityLogic
    {


        public static int Insert(City obj)
        {
            string query = "Insert City VALUES (@CityName, @CityDetails)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CityName", obj.CityName));
            par.Add(new SqlParameter("@CityDetails", obj.CityDetails));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(City obj)
        {
            string query = @"UPDATE City SET CityName = @CityName, CityDetails = @CityDetails 
                            WHERE CityID = @CityID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CityName", obj.CityName));
            par.Add(new SqlParameter("@CityDetails", obj.CityDetails));
            par.Add(new SqlParameter("@CityID", obj.CityID));

            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE City WHERE CityID = @CityID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CityID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static City SelectByID(int ID)
        {
            string query = "SELECT * FROM City WHERE CityID = @CityID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CityID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            City obj = new City();
            if (dt.Rows.Count == 1)
            {
                obj.CityID = Convert.ToInt32(dt.Rows[0]["CityID"]);
                obj.CityName = dt.Rows[0]["CityName"].ToString();
                obj.CityDetails = dt.Rows[0]["CityDetails"].ToString();
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM City";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM City WHERE CityName LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

    }
}
