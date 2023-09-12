using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class ServiceRequestLogic
    {
        public static int Insert(ServiceRequest obj)
        {
            string query = "Insert ServiceRequest VALUES (@VehicleID, @MechanicServiceID,  @RequestTime, @CreateTime,  @ServiceRequestDetails, @Status, @Reply, @CompletionTime, @Feedback, @Rating )";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@VehicleID", obj.VehicleID));
            par.Add(new SqlParameter("@MechanicServiceID", obj.MechanicServiceID));
            par.Add(new SqlParameter("@RequestTime", obj.RequestTime));           
            par.Add(new SqlParameter("@CreateTime", obj.CreateTime));
            par.Add(new SqlParameter("@ServiceRequestDetails", obj.ServiceRequestDetails));      
            par.Add(new SqlParameter("@Status", obj.Status));
            par.Add(new SqlParameter("@Reply", obj.Reply));
            par.Add(new SqlParameter("@CompletionTime", obj.CompletionTime));
            par.Add(new SqlParameter("@Feedback", obj.Feedback));
            par.Add(new SqlParameter("@Rating", obj.Rating));
           

            return DBUtility.ModifyData(query, par);
        }

        public static int Update(ServiceRequest obj)
        {
            string query = @"UPDATE ServiceRequest SET VehicleID= @VehicleID,  MechanicServiceID = @MechanicServiceID, RequestTime = @RequestTime, CreateTime = @CreateTime, ServiceRequestDetails = @ServiceRequestDetails, Status = @Status, Reply = @Reply, CompletionTime = @CompletionTime, Feedback = @Feedback, Rating = @Rating
                            WHERE ServiceRequestID = @ServiceRequestID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@VehicleID", obj.VehicleID));
            par.Add(new SqlParameter("@MechanicServiceID", obj.MechanicServiceID));
            par.Add(new SqlParameter("@RequestTime", obj.RequestTime));
            par.Add(new SqlParameter("@CreateTime", obj.CreateTime));
            par.Add(new SqlParameter("@ServiceRequestDetails", obj.ServiceRequestDetails));
            par.Add(new SqlParameter("@Status", obj.Status));
            par.Add(new SqlParameter("@Reply", obj.Reply));
            par.Add(new SqlParameter("@CompletionTime", obj.CompletionTime));
            par.Add(new SqlParameter("@Feedback", obj.Feedback));
            par.Add(new SqlParameter("@Rating", obj.Rating));
            par.Add(new SqlParameter("@ServiceRequestID", obj.ServiceRequestID));


            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE ServiceRequest WHERE ServiceRequestID = @ServiceRequestID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceRequestID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static ServiceRequest  SelectByID(int ID)
        {
            string query = "SELECT * FROM ServiceRequest WHERE ServiceRequestID = @ServiceRequestID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@ServiceRequestID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            ServiceRequest obj = new ServiceRequest();
            if (dt.Rows.Count == 1)
            {
                obj.ServiceRequestID = Convert.ToInt32(dt.Rows[0]["ServiceRequestID"]);
                obj.VehicleID = Convert.ToInt32(dt.Rows[0]["VehicleID"]);
                obj.Status = dt.Rows[0]["Status"].ToString();
                obj.MechanicServiceID = Convert.ToInt32(dt.Rows[0]["MechanicServiceID"]);
                obj.CompletionTime = Convert.ToDateTime(dt.Rows[0]["CompletionTime"]);
                obj.RequestTime = Convert.ToDateTime(dt.Rows[0]["RequestTime"]);
                obj.CreateTime = Convert.ToDateTime(dt.Rows[0]["CreateTime"]);
                obj.Reply = dt.Rows[0]["Reply"].ToString();
                obj.Feedback = dt.Rows[0]["Feedback"].ToString();
                obj.Rating = Convert.ToInt32(dt.Rows[0]["Rating"]);
                obj.ServiceRequestDetails = dt.Rows[0]["ServiceRequestDetails"].ToString();
            }
            return obj;
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM ServiceRequest";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectOutstandingRequestByMechanicID(int MechanicID)
        {
            string query = "SELECT * FROM ServiceRequest INNER JOIN MechanicService ON ServiceRequest.MechanicServiceID = MechanicService.MechanicServiceID INNER JOIN Vehicle ON ServiceRequest.VehicleID = Vehicle.VehicleID WHERE MechanicID = @MechanicID AND (Status = 'Pending' OR Status = 'Approved' OR Status = 'In Progress')";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectByCustomerID(int CustomerID)
        {
            string query = @"SELECT * FROM ServiceRequest 
                            INNER JOIN Vehicle ON ServiceRequest.VehicleID = Vehicle.VehicleID 
                            INNER JOIN MechanicService ON ServiceRequest.MechanicServiceID = MechanicService.MechanicServiceID 
                            INNER JOIN Mechanic ON Mechanic.MechanicID = MechanicService.MechanicID 
                            WHERE CustomerID = @CustomerID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@CustomerID", CustomerID));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectByMechanicID(int MechanicID)
        {
            string query = @"SELECT * FROM ServiceRequest 
INNER JOIN Vehicle ON ServiceRequest.VehicleID = Vehicle.VehicleID 
INNER JOIN MechanicService ON ServiceRequest.MechanicServiceID = MechanicService.MechanicServiceID 
INNER JOIN Mechanic ON Mechanic.MechanicID = MechanicService.MechanicID 
WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectFeedbackByMechanicID(int MechanicID)
        {
            string query = @"sElect SR.*, MS.*, C.CustomerName
                            FROM ServiceRequest as SR
                                INNER JOIN MechanicService as MS ON SR.MechanicServiceID = MS.MechanicServiceID
                                inner join Vehicle as V on V.VehicleID = SR.VehicleID
                                inner join Customer as C on C.CustomerID = V.CustomerID
                            WHERE MS.MechanicID = @MechanicID AND Feedback <> ''";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            return DBUtility.SelectData(query, par);
        }

        public static float SelectAverageRatingByMechanicID(int MechanicID)
        {
            string query = @"SELECT AVG(CONVERT(float,Rating)) AS 'Rating' 
                                FROM ServiceRequest
                                    INNER JOIN MechanicService ON ServiceRequest.MechanicServiceID = MechanicService.MechanicServiceID 
                                WHERE MechanicID = @MechanicID AND ServiceRequest.Status = 'Completed' AND ServiceRequest.Rating > 0 ";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            DataTable dt = DBUtility.SelectData(query, par);

            if (dt.Rows.Count == 1 && dt.Columns.Count == 1 && dt.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToSingle(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }

        public static DataTable SelectTodaysCalendarByMechanicID(int MechanicID)
        {
            string query = "SELECT * FROM ServiceRequest INNER JOIN MechanicService ON ServiceRequest.MechanicServiceID = MechanicService.MechanicServiceID INNER JOIN Vehicle ON ServiceRequest.VehicleID = Vehicle.VehicleID WHERE MechanicID = @MechanicID AND (RequestTime BETWEEN @Today AND @Tomorrow)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            par.Add(new SqlParameter("@Today", DateTime.Today));
            par.Add(new SqlParameter("@Tomorrow", DateTime.Today.AddDays(1)));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable SelectPastRequestByMechanicID(int MechanicID)
        {
            string query = "SELECT * FROM ServiceRequest INNER JOIN MechanicService ON ServiceRequest.MechanicServiceID = MechanicService.MechanicServiceID INNER JOIN Vehicle ON ServiceRequest.VehicleID = Vehicle.VehicleID WHERE MechanicID = @MechanicID AND (Status = 'Completed' OR Status = 'Cancelled')";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", MechanicID));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM ServiceRequest WHERE ServiceRequestID LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }
    }
}
