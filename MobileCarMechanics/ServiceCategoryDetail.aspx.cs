using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessLayer;
using LogicLayer;


public partial class ServiceCategoryDetail : System.Web.UI.Page
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
                int ServiceServiceCategoryID = Convert.ToInt32(Request.QueryString["ID"]);
                ServiceCategory obj = ServiceCategoryLogic.SelectByID(ServiceServiceCategoryID);
                txtServiceCategoryName.Text = obj.ServiceCategoryName;
                txtServiceCategoryDetails.Text = obj.ServiceCategoryDetails;
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
            ServiceCategory obj = new ServiceCategory();
            obj.ServiceCategoryName = txtServiceCategoryName.Text;
            obj.ServiceCategoryDetails = txtServiceCategoryDetails.Text;

            string prefix = DateTime.Now.Ticks.ToString();
            ServiceCategoryPhoto.SaveAs(Server.MapPath("servicecategoryuploads\\" + prefix + ServiceCategoryPhoto.FileName));
            obj.ServiceCategoryPhoto = prefix + ServiceCategoryPhoto.FileName;

            ServiceCategoryLogic.Insert(obj);

            Response.Redirect("ServiceCategorySearch.aspx");
        }
        else
        {
            ServiceCategory obj = ServiceCategoryLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.ServiceCategoryName = txtServiceCategoryName.Text;
            obj.ServiceCategoryDetails = txtServiceCategoryDetails.Text;

            if (ServiceCategoryPhoto.HasFile)
            {
                string prefix = DateTime.Now.Ticks.ToString();
                ServiceCategoryPhoto.SaveAs(Server.MapPath("servicecategoryuploads\\" + prefix + ServiceCategoryPhoto.FileName));
                obj.ServiceCategoryPhoto = prefix + ServiceCategoryPhoto.FileName;
            }

            ServiceCategoryLogic.Update(obj);

            Response.Redirect("ServiceCategorySearch.aspx");
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ServiceCategoryLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("ServiceCategorySearch.aspx");
    }
}