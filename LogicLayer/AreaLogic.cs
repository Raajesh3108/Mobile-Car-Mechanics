using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class AreaLogic
    {
         
        public static int Insert(Area obj)
        {
            string query = "Insert Area VALUES (@AreaName, @CityID, @AreaType)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaName", obj.AreaName));
            par.Add(new SqlParameter("@CityID", obj.CityID));
            par.Add(new SqlParameter("@AreaType", obj.AreaType));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(Area obj)
        {
            string query = @"UPDATE Area SET AreaName = @AreaName, CityID = @CityID, AreaType = @AreaType 
                            WHERE AreaID = @AreaID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaName", obj.AreaName));
            par.Add(new SqlParameter("@CityID", obj.CityID));
            par.Add(new SqlParameter("@AreaType", obj.AreaType));
            par.Add(new SqlParameter("@AreaID", obj.AreaID));

            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE Area WHERE AreaID = @AreaID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static Area SelectByID(int ID)
        {
            string query = "SELECT * FROM Area WHERE AreaID = @AreaID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            Area obj = new Area();
            if (dt.Rows.Count == 1)
            {
                obj.AreaID = Convert.ToInt32(dt.Rows[0]["AreaID"]);
                obj.AreaName = dt.Rows[0]["AreaName"].ToString();
                obj.CityID = Convert.ToInt32(dt.Rows[0]["CityID"]);
                obj.AreaType = dt.Rows[0]["AreaType"].ToString();
            }
            return obj;
        }

        public static DataTable SelectByCityID(int ID)
        {
            string query = "SELECT * FROM Area WHERE CityID = @CityID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CityID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            return dt;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM Area";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM Area INNER JOIN City ON City.CityID = Area.CityID WHERE AreaName LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

    }
}
