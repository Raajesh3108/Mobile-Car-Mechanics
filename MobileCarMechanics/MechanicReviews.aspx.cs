using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;

public partial class MechanicReviews : System.Web.UI.Page
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

            Customer c = (Customer)Session["Customer"];

            GridView1.DataSource = ServiceRequestLogic.SelectFeedbackByMechanicID(c.CustomerID);
            GridView1.DataBind();

        }
    }
}