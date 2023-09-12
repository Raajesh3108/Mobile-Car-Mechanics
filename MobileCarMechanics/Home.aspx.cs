using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{

    protected override void OnPreInit(EventArgs e)
    {
        if (Session["Customer"] != null)
        {
            Response.Redirect("CustomerHome.aspx");
        }
        else if (Session["Mechanic"] != null)
        {
            Response.Redirect("MechanicHome.aspx");
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerRegistration.aspx");
    }
    protected void btnMechanic_Click(object sender, EventArgs e)
    {
        Response.Redirect("MechanicRegistration.aspx");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }
}