using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;
using DataAccessLayer;

public partial class Customer_MyRequest : System.Web.UI.Page
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

            Customer m = (Customer)Session["Customer"];

            GridView1.DataSource = ServiceRequestLogic.SelectByCustomerID(m.CustomerID);
            GridView1.DataBind();

        }
    }
}