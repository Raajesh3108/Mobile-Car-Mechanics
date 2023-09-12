using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class MechanicAreaLogic
    {

        public static int Insert(MechanicArea obj)
        {
            string query = "Insert MechanicArea VALUES (@MechanicID, @AreaID)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaID", obj.AreaID));
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(MechanicArea obj)
        {
            string query = @"UPDATE MechanicArea SET MechanicAreaID = @MechanicAreaID, AreaID = @AreaID,  MechanicID = @MechanicID 
                            WHERE MechanicAreaID = @MechanicAreaID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaID", obj.AreaID));
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            par.Add(new SqlParameter("@MechanicAreaID", obj.MechanicAreaID));

            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE MechanicArea WHERE MechanicAreaID = @MechanicAreaID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicAreaID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static MechanicArea SelectByID(int ID)
        {
            string query = "SELECT * FROM MechanicArea WHERE MechanicAreaID = @MechanicAreaID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicAreaID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            MechanicArea obj = new MechanicArea();
            if (dt.Rows.Count == 1)
            {
                obj.AreaID = Convert.ToInt32(dt.Rows[0]["MechanicAreaID"]);
                obj.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                obj.AreaID = Convert.ToInt32(dt.Rows[0]["AreaID"]);
                
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM MechanicArea";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM MechanicArea INNER JOIN Mechanic ON Mechanic.MechanicID = MechanicArea.MechanicAreaID WHERE MechanicAreaID LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectByMechanicID(int MechanicID)
        {
            string query = "SELECT * FROM MechanicArea INNER JOIN Area ON Area.AreaID = MechanicArea.AreaID WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            return DBUtility.SelectData(query, par);
        }

    }
}

