using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class MechanicServiceLogic
    {
        public static int Insert(MechanicService obj)
        {
            string query = "Insert MechanicService VALUES (@MechanicID, @ServiceID, @Price, @EstimatedTime)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            par.Add(new SqlParameter("@ServiceID", obj.ServiceID));
            par.Add(new SqlParameter("@EstimatedTime", obj.EstimatedTime));
           
            par.Add(new SqlParameter("@Price", obj.Price));

            return DBUtility.ModifyData(query, par);
        }

        public static int Update(MechanicService obj)
        {
            string query = @"UPDATE MechanicService SET CutomerName= @CutomerName, ServiceID = @ServiceID, Comment = @Comment, EstimatedTime = @EstimatedTime, Price = @Price
                            WHERE MechanicServiceID = @MechanicServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            par.Add(new SqlParameter("@ServiceID", obj.ServiceID));
            par.Add(new SqlParameter("@EstimatedTime", obj.EstimatedTime));
            par.Add(new SqlParameter("@MechanicServiceID", obj.MechanicServiceID));

            par.Add(new SqlParameter("@Price", obj.Price));


            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE MechanicService WHERE MechanicServiceID = @MechanicServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicServiceID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static MechanicService SelectByID(int ID)
        {
            string query = "SELECT * FROM MechanicService WHERE MechanicServiceID = @MechanicServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicServiceID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            MechanicService obj = new MechanicService();
            if (dt.Rows.Count == 1)
            {
                 obj.MechanicServiceID = Convert.ToInt32(dt.Rows[0]["MechanicServiceID"]);
                obj.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                obj.ServiceID = Convert.ToInt32(dt.Rows[0]["ServiceID"]);
                obj.EstimatedTime = Convert.ToInt32(dt.Rows[0]["EstimatedTime"]);
                obj.Price = Convert.ToSingle(dt.Rows[0]["Price"]);
                
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM MechanicServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }
        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM MechanicService WHERE MechanicServiceID LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

        
           public static DataTable SelectByMechanicID(int id)
        {
            string query = "SELECT * FROM MechanicService INNER JOIN Service ON Service.ServiceID = MechanicService.ServiceID WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", id));
            return DBUtility.SelectData(query, par);
        
        }
    }
}
