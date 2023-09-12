using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;

public partial class OutstandingRequest : System.Web.UI.Page
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

        if (!IsPostBack)
        {

            Mechanic m = (Mechanic)Session["Mechanic"];

            GridView1.DataSource = ServiceRequestLogic.SelectOutstandingRequestByMechanicID(m.MechanicID);
            GridView1.DataBind();

        }
    }

    protected void btnComplete_Command(object sender, CommandEventArgs e)
    {
        ServiceRequest sr = ServiceRequestLogic.SelectByID(Convert.ToInt32(e.CommandArgument));
        sr.Status = "Completed";
        sr.CompletionTime = DateTime.Now;
        ServiceRequestLogic.Update(sr);
        Response.Redirect("OutstandingRequest.aspx");
    }

    protected void btnApprove_Command(object sender, CommandEventArgs e)
    {
        ServiceRequest sr = ServiceRequestLogic.SelectByID(Convert.ToInt32(e.CommandArgument));
        sr.Status = "Approved";
        ServiceRequestLogic.Update(sr);
        Response.Redirect("OutstandingRequest.aspx");
    }

    protected void btnStart_Command(object sender, CommandEventArgs e)
    {
        ServiceRequest sr = ServiceRequestLogic.SelectByID(Convert.ToInt32(e.CommandArgument));
        sr.Status = "In Progress";
        ServiceRequestLogic.Update(sr);
        Response.Redirect("OutstandingRequest.aspx");
    }
}