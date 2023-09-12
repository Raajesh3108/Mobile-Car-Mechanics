using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class ServiceCategoryLogic
    {
        public static int Insert(ServiceCategory obj)
        {
            string query = "Insert ServiceCategory VALUES (@ServiceCategoryName, @ServiceCategoryPhoto, @ServiceCategoryDetails)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryName", obj.ServiceCategoryName));
            par.Add(new SqlParameter("@ServiceCategoryPhoto", obj.ServiceCategoryPhoto));
            par.Add(new SqlParameter("@ServiceCategoryDetails", obj.ServiceCategoryDetails));
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(ServiceCategory obj)
        {
            string query = @"UPDATE ServiceCategory SET ServiceCategoryName = @ServiceCategoryName, ServiceCategoryPhoto = @ServiceCategoryPhoto, ServiceCategoryDetails = @ServiceCategoryDetails
                            WHERE ServiceCategoryID = @ServiceCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryName", obj.ServiceCategoryName));
            par.Add(new SqlParameter("@ServiceCategoryPhoto", obj.ServiceCategoryPhoto));
            par.Add(new SqlParameter("@ServiceCategoryDetails", obj.ServiceCategoryDetails));
            par.Add(new SqlParameter("@ServiceCtegoryID", obj.ServiceCategoryID));

            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE ServiceCategory WHERE ServiceCategoryID = @ServiceCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static ServiceCategory SelectByID(int ID)
        {
            string query = "SELECT * FROM ServiceCategory WHERE ServiceCategoryID = @ServiceCategoryID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceCategoryID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            ServiceCategory obj = new ServiceCategory();
            if (dt.Rows.Count == 1)
            {
                obj.ServiceCategoryID = Convert.ToInt32(dt.Rows[0]["ServiceCategoryID"]);
                obj.ServiceCategoryName = dt.Rows[0]["ServiceCategoryName"].ToString();
                obj.ServiceCategoryPhoto = dt.Rows[0]["ServiceCategoryPhoto"].ToString();
                obj.ServiceCategoryDetails = dt.Rows[0]["ServiceCategoryDetails"].ToString();
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM ServiceCategory";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM ServiceCategory WHERE ServiceCategoryName LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }
    }
}
