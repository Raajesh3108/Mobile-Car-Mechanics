using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using System.Data;


public partial class CustomerProfile : System.Web.UI.Page
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
            DataTable dt = AreaLogic.SelectAll();
            ddlArea.DataSource = dt;
            ddlArea.DataTextField = "AreaName";
            ddlArea.DataValueField = "AreaID";
            ddlArea.DataBind();


            Customer c = (Customer)Session["Customer"];
                txtCustomerName.Text = c.CustomerName;
                txtCustomerEmail.Text = c.CustomerEmail;
                ddlArea.SelectedValue = c.AreaID.ToString();
                txtCustomerMobile.Text = c.CustomerMoblieNo;
                txtCustomerAddress.Text = c.CustomerAddress;
               
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] == null)
        {
            Customer c = (Customer)Session["Customer"];
            c.CustomerName = txtCustomerName.Text;
            c.CustomerEmail = txtCustomerEmail.Text;
            c.AreaID = Convert.ToInt32(ddlArea.SelectedItem.Value);
            c.CustomerMoblieNo = txtCustomerMobile.Text;
            c.CustomerAddress = txtCustomerAddress.Text;
      
          
            
            if (CustomerPhoto.HasFile)
            {
                string prefix = DateTime.Now.Ticks.ToString();
                CustomerPhoto.SaveAs(Server.MapPath("customeruploads\\" + prefix + CustomerPhoto.FileName));
                c.CustomerPhoto = prefix + CustomerPhoto.FileName;
            }



            SuccessMsg.Visible = true;
            SuccessMsg1.Visible = false;
            FailedMSg1.Visible = false;
            CustomerLogic.Update(c);
            Session["Customer"] = c;

        }
    }
    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        Customer c = (Customer)Session["Customer"];
        if (txtoCustomerOldPassword.Text == c.CustomerPassword)
        {
            c.CustomerPassword = txtCustomerNewPassword.Text;
            SuccessMsg1.Visible = true;
            SuccessMsg.Visible = false;
            CustomerLogic.Update(c);
            Session["Customer"] = c;
        }
        else
        {
            SuccessMsg1.Visible = false;
            FailedMSg1.Visible = true;
            SuccessMsg.Visible = false;
        }
    }
}