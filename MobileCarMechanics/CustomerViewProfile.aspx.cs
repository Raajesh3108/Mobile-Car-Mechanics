using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicLayer;

public partial class CustomerViewProfile : System.Web.UI.Page
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
        //if (!IsPostBack)
        //{

            //if (Request.QueryString["ID"] != null)
            //{
                // edit mode
        Customer obj = (Customer)Session["Customer"];
        txtCustomerName.Text = obj.CustomerName;
                txtCustomerAddress.Text = obj.CustomerAddress;
                txtCustomerEmail.Text = obj.CustomerEmail;
                txtCustomerMobileNo.Text = obj.CustomerMoblieNo;
                txtCustomerUsername.Text = obj.CustomerUsername;
                Image1.ImageUrl = "customeruploads/" + obj.CustomerPhoto;
                txtArea.Text = AreaLogic.SelectByID(obj.AreaID).AreaName;
        //    }          

        //}
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
            Response.Redirect("CustomerProfile.aspx");
    
    }
}