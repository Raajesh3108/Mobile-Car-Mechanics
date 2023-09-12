using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;

public partial class Customer_Feedback : System.Web.UI.Page
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
            ServiceRequest SR = ServiceRequestLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            txtFeedback.Text = SR.Feedback;
            ddlRating.Text = SR.Rating.ToString();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ServiceRequest SR = ServiceRequestLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
        SR.Feedback = txtFeedback.Text;
        SR.Rating = Convert.ToInt32(ddlRating.Text);
        ServiceRequestLogic.Update(SR);

        Response.Redirect("Customer_MyRequest.aspx");
    }
}