using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using DataAccessLayer;
using System.Data;

public partial class ServiceRequestDetail : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Admin"] == null)
        {
            Response.Redirect("Unauthorized.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DataTable dt = VehicleLogic.SelectAll();
            ddlVehicle.DataSource = dt;
            ddlVehicle.DataTextField = "VehicleNumber";
            ddlVehicle.DataValueField = "VehicleID";
            ddlVehicle.DataBind();
     
            

            if (Request.QueryString["ID"] != null)
            {
                // edit mode
                ServiceRequest obj = ServiceRequestLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
              
                txtServiceRequestDetails.Text = obj.ServiceRequestDetails;
                ddlVehicle.SelectedValue = obj.VehicleID.ToString();
                ddlStatus.SelectedValue = obj.Status;
                txtReply.Text = obj.Reply;

                if (Session["Mechanic"] != null)
                {
                    btnSubmitReply.Visible = true;
                }
                if (Session["Customer"] != null)
                {
                    btnSubmitFeedbackRating.Visible = true;
                }
            }
        }
    }

    protected void btnSubmitFeedbackRating_Click(object sender, EventArgs e)
    {
        ServiceRequest obj = ServiceRequestLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
        obj.Feedback = txtFeedback.Text;
        obj.Rating = Convert.ToInt32(ddlRating.SelectedItem.Value);
        ServiceRequestLogic.Update(obj);

        Response.Redirect("ServiceRequestDetail.aspx?ID=" + Request.QueryString["ID"]);
    }

    protected void btnSubmitReply_Click(object sender, EventArgs e)
    {
        ServiceRequest obj = ServiceRequestLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
        obj.Reply = txtReply.Text;
        ServiceRequestLogic.Update(obj);

        Response.Redirect("ServiceRequestDetail.aspx?ID=" + Request.QueryString["ID"]);
    }
}