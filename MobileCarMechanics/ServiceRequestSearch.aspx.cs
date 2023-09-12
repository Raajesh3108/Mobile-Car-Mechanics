using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;
using DataAccessLayer;

public partial class ServiceRequestSearch : System.Web.UI.Page
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

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        GridViewArea.DataSource = ServiceRequestLogic.Search(txtServiceRequestName.Text);
        GridViewArea.DataBind();
    }
}