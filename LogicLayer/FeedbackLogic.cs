using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class FeedbackLogic
    {
        public static int Insert(Feedback obj)
        {
            string query = "Insert Feedback VALUES (@MechanicID, @CustomerID, @Comment, @CommentTime, @RateValue)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            par.Add(new SqlParameter("@CustomerID", obj.CustomerID));
            
            par.Add(new SqlParameter("@Comment", obj.Comment));
            par.Add(new SqlParameter("@CommentTime", obj.CommentTime));
            par.Add(new SqlParameter("@RateValue", obj.RateValue));
            
            return DBUtility.ModifyData(query, par);
        }

        public static int Update(Feedback obj)
        {
            string query = @"UPDATE Feedback SET MechanicID= @MechanicID, CustomerID = @CustomerID, Comment = @Comment, CommentTime = @CommentTime, RateValue = @RateValue
                            WHERE FeedbackID = @FeedbackID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));
            par.Add(new SqlParameter("@CustomerID", obj.CustomerID));
            par.Add(new SqlParameter("@CustomerID", obj.CustomerID));
            par.Add(new SqlParameter("@Comment", obj.Comment));
            par.Add(new SqlParameter("@CommentTime", obj.CommentTime));
            par.Add(new SqlParameter("@RateValue", obj.RateValue));
            par.Add(new SqlParameter("@FeedbackID", obj.FeedbcakID));

        
            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE Feedback WHERE FeedbackID = @FeedbackID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@FeedbackID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static Feedback SelectByID(int ID)
        {
            string query = "SELECT * FROM Feedback WHERE FeedbackID = @FeedbackID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@FeedbackID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            Feedback obj = new Feedback();
            if (dt.Rows.Count == 1)
            {
                obj.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                obj.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                 obj.Comment = dt.Rows[0]["Comment"].ToString();
               
                obj.CommentTime = Convert.ToDateTime(dt.Rows[0]["CommentTime"]);
                obj.RateValue = Convert.ToSingle(dt.Rows[0]["RateValue"]);
                
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM FeedbackID";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }
        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM Feedback WHERE FeedbackID LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }
    }
}
