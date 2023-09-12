using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace LogicLayer
{
    public class MechanicLogic
    {
        public static int Insert(Mechanic obj)
        {
            string query = "Insert Mechanic VALUES (@MechanicName, @MechanicAddress, @CityID,  @MechanicEmail, @MechanicUsername, @MechanicPassword, @MechanicPhoto, @MechanicMobileNo, @MechanicPhotoProof)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicName", obj.MechanicName));
            par.Add(new SqlParameter("@MechanicAddress", obj.MechanicAddress));
            par.Add(new SqlParameter("@CityID", obj.CityID));
            par.Add(new SqlParameter("@MechanicEmail", obj.MechanicEmail));
            par.Add(new SqlParameter("@MechanicUsername", obj.MechanicUsername));
            par.Add(new SqlParameter("@MechanicPassword", obj.MechanicPassword));
            par.Add(new SqlParameter("@MechanicPhoto", obj.MechanicPhoto));
            par.Add(new SqlParameter("@MechanicMobileNo", obj.MechanicMobileNo));
            par.Add(new SqlParameter("@MechanicPhotoProof", obj.MechanicPhotoProof));

            return DBUtility.ModifyData(query, par);
        }

        public static int Update(Mechanic obj)
        {
            string query = @"UPDATE Mechanic SET MechanicName= @MechanicName, MechanicAddress= @MechanicAddress, CityID = @CityID, MechanicEmail = @MechanicEmail, MechanicUsername = @MechanicUsername, MechanicPassword = @MechanicPassword, MechanicPhoto = @MechanicPhoto, MechanicMobileNo = @MechanicMobileNo, MechanicPhotoProof = @MechanicPhotoProof
                            WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicName", obj.MechanicName));
            par.Add(new SqlParameter("@MechanicAddress", obj.MechanicAddress));
            par.Add(new SqlParameter("@CityID", obj.CityID));
            par.Add(new SqlParameter("@MechanicEmail", obj.MechanicEmail));
            par.Add(new SqlParameter("@MechanicUsername", obj.MechanicUsername));
            par.Add(new SqlParameter("@MechanicPassword", obj.MechanicPassword));
            par.Add(new SqlParameter("@MechanicPhoto", obj.MechanicPhoto));
            par.Add(new SqlParameter("@MechanicMobileNo", obj.MechanicMobileNo));       
            par.Add(new SqlParameter("@MechanicPhotoProof", obj.MechanicPhotoProof));
            par.Add(new SqlParameter("@MechanicID", obj.MechanicID));

            return DBUtility.ModifyData(query, par);
        }

        public static int Delete(int ID)
        {
            string query = "DELETE Mechanic WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", ID));
            return DBUtility.ModifyData(query, par);
        }

        public static Mechanic SelectByID(int ID)
        {
            string query = "SELECT * FROM Mechanic WHERE MechanicID = @MechanicID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicID", ID));
            DataTable dt = DBUtility.SelectData(query, par);

            Mechanic obj = new Mechanic();
            if (dt.Rows.Count == 1)
            {
                obj.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                obj.MechanicEmail = dt.Rows[0]["MechanicEmail"].ToString();
                obj.CityID = Convert.ToInt32(dt.Rows[0]["CityID"]);
                obj.MechanicMobileNo = dt.Rows[0]["MechanicMobileNo"].ToString();
                obj.MechanicAddress = dt.Rows[0]["MechanicAddress"].ToString();
                obj.MechanicUsername = dt.Rows[0]["MechanicUsername"].ToString();
                obj.MechanicPassword = dt.Rows[0]["MechanicPassword"].ToString();
                obj.MechanicPhoto = dt.Rows[0]["MechanicPhoto"].ToString();
                obj.MechanicPhotoProof = dt.Rows[0]["MechanicPhotoProof"].ToString();
                obj.MechanicName = dt.Rows[0]["MechanicName"].ToString();

            }
            return obj;
        }


        public static Mechanic SelectByUsername(String MechanicUsername)
        {
            string query = "SELECT * FROM Mechanic WHERE MechanicUsername = @MechanicUserame";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicUsername", MechanicUsername));
            DataTable dt = DBUtility.SelectData(query, par);

            Mechanic obj = new Mechanic();
            if (dt.Rows.Count == 1)
            {
                obj.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                obj.MechanicEmail = dt.Rows[0]["MechanicEmail"].ToString();
                obj.CityID = Convert.ToInt32(dt.Rows[0]["CityID"]);
                obj.MechanicMobileNo = dt.Rows[0]["MechanicMobileNo"].ToString();
                obj.MechanicAddress = dt.Rows[0]["MechanicAddress"].ToString();
                obj.MechanicUsername = dt.Rows[0]["MechanicUsername"].ToString();
                obj.MechanicPassword = dt.Rows[0]["MechanicPassword"].ToString();
                obj.MechanicPhoto = dt.Rows[0]["MechanicPhoto"].ToString();
                obj.MechanicPhotoProof = dt.Rows[0]["MechanicPhotoProof"].ToString();
                obj.MechanicName = dt.Rows[0]["MechanicName"].ToString();

            }
            return obj;
        }


        public static Mechanic Validate(string MechanicUsername, string MechanicPassword)
        {
            string query = @"SELECT * FROM Mechanic WHERE MechanicUsername = @MechanicUsername AND MechanicPassword = @MechanicPassword";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicUsername", MechanicUsername));
            par.Add(new SqlParameter("@MechanicPassword", MechanicPassword));

            DataTable dt = DBUtility.SelectData(query, par);

            if (dt.Rows.Count == 1)
            {
                Mechanic M = new Mechanic();
                M.MechanicID = Convert.ToInt32(dt.Rows[0]["MechanicID"]);
                M.MechanicName = dt.Rows[0]["MechanicName"].ToString();
                M.MechanicAddress = dt.Rows[0]["MechanicAddress"].ToString();
                M.CityID = Convert.ToInt32(dt.Rows[0]["CityID"]);
                M.MechanicEmail = dt.Rows[0]["MechanicEmail"].ToString();
                M.MechanicUsername = dt.Rows[0]["MechanicUsername"].ToString();
                M.MechanicPassword = dt.Rows[0]["MechanicPassword"].ToString();
                M.MechanicPhoto = dt.Rows[0]["MechanicPhoto"].ToString();
                M.MechanicMobileNo = dt.Rows[0]["MechanicMobileNo"].ToString();
                M.MechanicPhotoProof = dt.Rows[0]["MechanicPhotoProof"].ToString();

                return M;
            }
            else
            {
                return new Mechanic();
            }
        }

        public static DataTable SelectAll()
        {
            string query = "SELECT * FROM MechanicName";
            List<SqlParameter> par = new List<SqlParameter>();
            return DBUtility.SelectData(query, par);
        }
        public static DataTable Search(string Name)
        {
            string query = "SELECT * FROM Mechanic INNER JOIN City ON City.CityID = Mechanic.CityID WHERE MechanicName LIKE '%'+@Name+'%'";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", Name));
            return DBUtility.SelectData(query, par);
        }

        public static DataTable Search(int AreaID, int ServiceCategoryID, int ServiceID)
        {
            string query = @"SELECT *
                            FROM Mechanic M
                                INNER JOIN MechanicArea MA ON MA.MechanicID = M.MechanicID
                                INNER JOIN MechanicCategory MC ON MC.MechanicID = M.MechanicID
                                INNER JOIN MechanicService MS ON MS.MechanicID = M.MechanicID
                            WHERE MA.AreaID = @AreaID AND MC.ServiceCategoryID = @ServiceCategoryID AND MS.ServiceID = @ServiceID";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@AreaID", AreaID));
            par.Add(new SqlParameter("@ServiceCategoryID", ServiceCategoryID));
            par.Add(new SqlParameter("@ServiceID", ServiceID));
            return DBUtility.SelectData(query, par);
        }

        public static bool checkAvailable(string username)
        {
            string query = @"SELECT * FROM Mechanic WHERE MechanicUsername = @MechanicUsername";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@MechanicUsername", username));
            DataTable dt = DBUtility.SelectData(query, par);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
