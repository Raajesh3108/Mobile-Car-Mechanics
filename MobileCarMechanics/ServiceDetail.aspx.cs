using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;

public partial class ServiceDetail : System.Web.UI.Page
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
            DataTable dt = ServiceCategoryLogic.SelectAll();
            ddlServiceCategory.DataSource = dt;
            ddlServiceCategory.DataTextField = "ServiceCategoryName";
            ddlServiceCategory.DataValueField = "ServiceCategoryID";
            ddlServiceCategory.DataBind();

            if (Request.QueryString["ID"] != null)
            {

                Service obj = ServiceLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
                txtServiceName.Text = obj.ServiceName;
                txtServiceDetails.Text = obj.ServiceDetails;
                ddlServiceCategory.SelectedValue = obj.ServiceCategoryID.ToString();

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
            Service obj = new Service();
            obj.ServiceName = txtServiceName.Text;
            obj.ServiceCategoryID = Convert.ToInt32(ddlServiceCategory.SelectedItem.Value);
            obj.ServiceDetails = txtServiceDetails.Text;
            
            string prefix = DateTime.Now.Ticks.ToString();
            ServicePhoto.SaveAs(Server.MapPath("serviceuploads\\" + prefix + ServicePhoto.FileName));
            obj.ServicePhoto = prefix + ServicePhoto.FileName;

            ServiceLogic.Insert(obj);

            Response.Redirect("ServiceSearch.aspx");
        }
        else
        {
            Service obj = ServiceLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.ServiceName = txtServiceName.Text;
            obj.ServiceCategoryID = Convert.ToInt32(ddlServiceCategory.SelectedItem.Value);
            obj.ServiceDetails = txtServiceDetails.Text;
            

            if (ServicePhoto.HasFile)
            {
                string prefix = DateTime.Now.Ticks.ToString();
                ServicePhoto.SaveAs(Server.MapPath("serviceuploads\\" + prefix + ServicePhoto.FileName));
                obj.ServicePhoto = prefix + ServicePhoto.FileName;
            }
            ServiceLogic.Update(obj);

            Response.Redirect("ServiceSearch.aspx");
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ServiceLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("ServiceSearch.aspx");
    }
}