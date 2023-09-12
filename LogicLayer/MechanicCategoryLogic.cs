using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class MechanicCategoryLogic
    {

        public static int Insert(MechanicCategory obj)
        {
            string query = "Insert MechanicCategory VALUES (@MechanicID, @ServiceCategoryID)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryID", obj.ServiceCategoryID));
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(MechanicCategory obj)
        {
            string query = @"UPDATE MechanicCategory SET ServiceCategoryID = @ServiceCategoryID, ServiceCategoryID = @ServiceCategoryID,  MechanicID = @MechanicID 
                            WHERE MechanicCategoryID = @MechanicCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryID", obj.ServiceCategoryID));
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            par.Add(new SqlParameter("@MechanicCategoryID", obj.MechanicCategoryID));
            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE MechanicCategory WHERE MechanicCategoryID = @MechanicCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicCategoryID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static MechanicCategory SelectByID(int ID)
        {
            string query = "SELECT * FROM MechanicCategory WHERE MechanicCategoryID = @MechanicCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicCategoryID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            MechanicCategory obj = new MechanicCategory();
            if (dt.Rows.Count == 1)
            {
                obj.ServiceCategoryID = Convert.ToInt32(dt.Rows[0]["ServiceCategoryID"]);
                obj.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                obj.MechanicCategoryID = ID;
                
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM MechanicCategory";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }
        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM MechanicCategory WHERE MechanicCategoryID LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectByMechanicID(int id)
        {
            string query = "SELECT * FROM MechanicCategory INNER JOIN ServiceCategory ON ServiceCategory.ServiceCategoryID = MechanicCategory.ServiceCategoryID WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", id));
            return DBUtility.SelectData(query, par);
        }
    }
}
