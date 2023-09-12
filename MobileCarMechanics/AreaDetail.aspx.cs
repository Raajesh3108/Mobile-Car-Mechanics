using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using DataAccessLayer;
using System.Data;

public partial class AreaDetail : System.Web.UI.Page
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
            DataTable dt = CityLogic.SelectAll();
            ddlCity.DataSource = dt;
            ddlCity.DataTextField = "CityName";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();


            if (Request.QueryString["ID"] != null)
            {
                // edit mode
                Area obj = AreaLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
                txtAreaName.Text = obj.AreaName;
                ddlAreaType.SelectedValue = obj.AreaType;
                ddlCity.SelectedValue = obj.CityID.ToString();
            }
            else
            {
                btnDelete.Visible = false;
            }

        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            Area obj = new Area();
            obj.AreaName = txtAreaName.Text;
            obj.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);
            obj.AreaType = ddlAreaType.SelectedItem.Value;
            
            AreaLogic.Insert(obj);

            Response.Redirect("AreaSearch.aspx");
        }
        else
        {
            Area obj = AreaLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.AreaName = txtAreaName.Text;
            obj.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);
            obj.AreaType = ddlAreaType.SelectedItem.Value;
            
           
            AreaLogic.Update(obj);

            Response.Redirect("AreaSearch.aspx");
        }
        
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        AreaLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("AreaSearch.aspx");
    }
}