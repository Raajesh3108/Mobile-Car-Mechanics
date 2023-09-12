using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;


public partial class Customer_SearchService : System.Web.UI.Page
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
            DataTable dt = CityLogic.SelectAll();
            ddlCity.DataSource = dt;
            ddlCity.DataTextField = "CityName";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();
            ddlCity_SelectedIndexChanged(sender, e);

            dt = ServiceCategoryLogic.SelectAll();
            ddlServiceCategory.DataSource = dt;
            ddlServiceCategory.DataTextField = "ServiceCategoryName";
            ddlServiceCategory.DataValueField = "ServiceCategoryID";
            ddlServiceCategory.DataBind();
            ddlServiceCategory_SelectedIndexChanged(sender, e);
        }
    }

    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = AreaLogic.SelectByCityID(Convert.ToInt32(ddlCity.SelectedItem.Value));
        ddlArea.DataSource = dt;
        ddlArea.DataTextField = "AreaName";
        ddlArea.DataValueField = "AreaID";
        ddlArea.DataBind();
    }
    protected void ddlServiceCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = ServiceLogic.SelectByServiceCategoryID(Convert.ToInt32(ddlServiceCategory.SelectedItem.Value));
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void btnSelectService_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("Customer_Mechanic.aspx?CID=" + ddlCity.SelectedItem.Value + "&AID=" + ddlArea.SelectedItem.Value + "&SCID=" + ddlServiceCategory.SelectedItem.Value + "&SID=" + e.CommandArgument);
    }

}