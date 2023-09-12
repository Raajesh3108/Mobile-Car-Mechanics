using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicLayer;
using DataAccessLayer;
using System.Data;

public partial class CustomerDetail : System.Web.UI.Page
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
            DataTable dt = AreaLogic.SelectAll();
            ddlArea.DataSource = dt;
            ddlArea.DataTextField = "AreaName";
            ddlArea.DataValueField = "AreaID";
            ddlArea.DataBind();


            if (Request.QueryString["ID"] != null)
            {
                // edit mode
                Customer obj = CustomerLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
                txtCustomerName.Text = obj.CustomerName;
                txtCustomerEmail.Text = obj.CustomerEmail;
                ddlArea.SelectedValue = obj.AreaID.ToString();
                txtCustomerMobileNo.Text = obj.CustomerMoblieNo;
                txtCustomerAddress.Text = obj.CustomerAddress;
                txtCustomerUsername.Text = obj.CustomerUsername;
                txtPassword.Text = obj.CustomerPassword;
                txtCustomerUsername.Enabled = false;

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
            // insert mode
            // check if username is available

            bool isAvailable1 = CustomerLogic.checkAvailable(txtCustomerUsername.Text);
            bool isAvailable2 = MechanicLogic.checkAvailable(txtCustomerUsername.Text);
           
            if (!isAvailable1 || !isAvailable2)
            {
                Response.Write("<script>alert('Username already taken. Please enter another username.')</script>");
                return;
            }

            Customer obj = new Customer();
            obj.CustomerName = txtCustomerName.Text;
            obj.CustomerEmail = txtCustomerEmail.Text;
            obj.AreaID = Convert.ToInt32(ddlArea.SelectedItem.Value);
            obj.CustomerMoblieNo = txtCustomerMobileNo.Text;
            obj.CustomerAddress = txtCustomerAddress.Text;
            obj.CustomerUsername = txtCustomerUsername.Text;
            obj.CustomerPassword = txtPassword.Text;

            string prefix = DateTime.Now.Ticks.ToString();
            CustomerPhoto.SaveAs(Server.MapPath("customeruploads\\" + prefix + CustomerPhoto.FileName));
            obj.CustomerPhoto = prefix + CustomerPhoto.FileName;
            
            CustomerLogic.Insert(obj);

            Response.Redirect("CustomerSearch.aspx");
        }
        else
        {
            Customer obj = CustomerLogic.SelectByID(Convert.ToInt32(Request.QueryString["ID"]));
            obj.CustomerName = txtCustomerName.Text;
            obj.CustomerEmail = txtCustomerEmail.Text;
            obj.AreaID = Convert.ToInt32(ddlArea.SelectedItem.Value);
            obj.CustomerMoblieNo = txtCustomerMobileNo.Text;
            obj.CustomerAddress = txtCustomerAddress.Text;
            obj.CustomerUsername = txtCustomerUsername.Text;
            obj.CustomerPassword = txtPassword.Text;

            if (CustomerPhoto.HasFile)
            {
                string prefix = DateTime.Now.Ticks.ToString();
                CustomerPhoto.SaveAs(Server.MapPath("customeruploads\\" + prefix + CustomerPhoto.FileName));
                obj.CustomerPhoto = prefix + CustomerPhoto.FileName;
            }
  


            CustomerLogic.Update(obj);

            Response.Redirect("CutomerSearch.aspx");
        }
        
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        CustomerLogic.Delete(Convert.ToInt32(Request.QueryString["ID"]));
        Response.Redirect("CustomerSearch.aspx");
    }
}