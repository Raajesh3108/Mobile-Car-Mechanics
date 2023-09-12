using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using System.Data;

public partial class MechanicViewProfile : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Mechanic"] == null)
        {
            Response.Redirect("Unauthorized.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
                
        Mechanic obj = (Mechanic)Session["Mechanic"];
                txtMechanicName.Text = obj.MechanicName;
                txtMechanicAddress.Text = obj.MechanicAddress;
                txtMechanicEmail.Text = obj.MechanicEmail;
                txtMechanicMobileNo.Text = obj.MechanicMobileNo;
                txtMechanicUsername.Text = obj.MechanicUsername;
                Image1.ImageUrl = "mechanicuploads/" + obj.MechanicPhoto;
                txtCity.Text = CityLogic.SelectByID(obj.CityID).CityName;


                lblAvgRating.Text = ServiceRequestLogic.SelectAverageRatingByMechanicID(obj.MechanicID).ToString("0.0");
            

        
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            Response.Redirect("MechanicProfile.aspx?ID=" + Request.QueryString["ID"]);
        }
    }
}