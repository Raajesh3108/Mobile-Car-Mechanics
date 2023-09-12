using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;

public partial class PastRequest : System.Web.UI.Page
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

            GridView1.DataSource = ServiceRequestLogic.SelectPastRequestByMechanicID(m.MechanicID);
            GridView1.DataBind();

        }
    }
}