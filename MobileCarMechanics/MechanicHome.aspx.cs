using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MechanicHome : System.Web.UI.Page
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

    }
}