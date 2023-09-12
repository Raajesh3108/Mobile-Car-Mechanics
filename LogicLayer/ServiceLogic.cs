using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class ServiceLogic
    {
        public static int Insert(Service obj)
        {
            string query = "Insert Service VALUES (@ServiceName, @ServicePhoto, @ServiceDetails, @ServiceCategoryID)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceName", obj.ServiceName));
            par.Add(new SqlParameter("@ServicePhoto", obj.ServicePhoto));
            par.Add(new SqlParameter("@ServiceDetails", obj.ServiceDetails));
            par.Add(new SqlParameter("@ServiceCategoryID", obj.ServiceCategoryID));
            
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(Service obj)
        {
            string query = @"UPDATE Service SET ServiceName = @ServiceName, ServicePhoto = @ServicePhoto, ServiceDetails = @ServiceDetails, ServiceCategoryID = @ServiceCategoryID
                            WHERE ServiceID = @ServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceName", obj.ServiceName));
            par.Add(new SqlParameter("@ServicePhoto", obj.ServicePhoto));
            par.Add(new SqlParameter("@ServiceDetails", obj.ServiceDetails));
            par.Add(new SqlParameter("@ServiceCategoryID", obj.ServiceCategoryID));
            par.Add(new SqlParameter("@ServiceID", obj.ServiceID));
            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE Service WHERE ServiceID = @ServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static Service SelectByID(int ID)
        {
            string query = "SELECT * FROM Service WHERE ServiceID = @ServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            Service obj = new Service();
            if (dt.Rows.Count == 1)
            {
                obj.ServiceID = Convert.ToInt32(dt.Rows[0]["ServiceID"]);
                obj.ServiceName = dt.Rows[0]["ServiceName"].ToString();
                obj.ServicePhoto = dt.Rows[0]["ServicePhoto"].ToString();
                obj.ServiceCategoryID = Convert.ToInt32(dt.Rows[0]["ServiceCategoryID"]);
                obj.ServiceDetails = dt.Rows[0]["ServiceDetails"].ToString();
            }
            return obj;
        }

        public static DataTable SelectByServiceCategoryID(int ID)
        {
            string query = "SELECT * FROM Service WHERE ServiceCategoryID = @ServiceCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            return dt;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM Service";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM Service INNER JOIN ServiceCategory ON ServiceCategory.ServiceCategoryID = Service.ServiceCategoryID WHERE ServiceName LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }
    }
}
