using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using DataAccessLayer;

public partial class CityDetail : System.Web.UI.Page
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
            if (Request.QueryString["ID"] != null)
            {
                int CityID = Convert.ToInt32(Request.QueryString["ID"]);
                City C = CityLogic.SelectByID(CityID);
                txtCityName.Text = C.CityName;
                TxtCityDetails.Text = C.CityDetails;
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
            City obj = new City();
            obj.CityName = txtCityName.Text;
            obj.CityDetails = TxtCityDetails.Text;
            
            CityLogic.Insert(obj);

            Response.Redirect("CitySearch.aspx");
        }
        else
        {
            City obj = CityLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.CityName = txtCityName.Text;
            obj.CityDetails = TxtCityDetails.Text;
            
            CityLogic.Update(obj);

            Response.Redirect("CitySearch.aspx");
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        CityLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("CitySearch.aspx");
    }
}