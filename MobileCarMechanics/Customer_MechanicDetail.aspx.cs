using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;


public partial class Customer_MechanicDetail : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Customer"] == null)
        {
            Response.Redirect("Unauthorized.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Request.QueryString["ID"] != null)
            {

                // edit mode
                Mechanic obj = MechanicLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
                txtMechanicName.Text = obj.MechanicName;
                txtMechanicAddress.Text = obj.MechanicAddress;
                txtMechanicEmail.Text = obj.MechanicEmail;               
                txtMechanicMobileNo.Text = obj.MechanicMobileNo;
                Image1.ImageUrl = "mechanicuploads/"+ obj.MechanicPhoto;
                txtCity.Text = CityLogic.SelectByID(obj.CityID).CityName;

                GridView1.DataSource = ServiceRequestLogic.SelectFeedbackByMechanicID(obj.MechanicID);
                GridView1.DataBind();

                lblAvgRating.Text = ServiceRequestLogic.SelectAverageRatingByMechanicID(obj.MechanicID).ToString("0.0");
            }
            
        }
    }
}